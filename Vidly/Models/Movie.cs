using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; } = DateTime.Now;

        [Required]
        [Range(1,20, ErrorMessage ="The field Number in Stock must be between 1 and 20.")]
        [Display(Name = "Number In Stock")]
        public short NumberInStock { get; set; }
        public short NumnerAvailable { get; set; }


        public Genre Genre { get; set; }


        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }


    }
}