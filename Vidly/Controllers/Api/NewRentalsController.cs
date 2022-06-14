using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;
        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto newRental)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            if (newRental.movieIds.Count == 0) return BadRequest("No movie ids have been given.");

            var customer = _context.Customers.SingleOrDefault(c => c.Id == newRental.CustomerId);
            if (customer == null) return BadRequest("Customer id is not valid");
           
            var movies = _context.Movies.Where(
                m => newRental.movieIds.Contains(m.Id)).ToList();

            if (movies.Count != newRental.movieIds.Count)
                return BadRequest("One or more movieIds are invalid.");


            foreach(var movie in movies)
            {
                if (movie.NumnerAvailable == 0)
                    return BadRequest("Movie is not available.");

                movie.NumnerAvailable--;
                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRental = DateTime.Now,
                };
                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();
            return Ok();
        }
    }
}
