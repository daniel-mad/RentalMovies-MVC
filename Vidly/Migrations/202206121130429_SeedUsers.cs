namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8d63f7e6-c6c3-4c3d-af3f-b9f796446e77', N'admin@mail.com', 0, N'AONZBkJSHAJmP3yDw8VhNC5W51RcHdSy1p/B6SejCSC23FgWge8EcSnxmq7S4qx0Lg==', N'f8a2d537-d406-495c-bfbe-f27cf72e2eb3', NULL, 0, 0, NULL, 1, 0, N'admin@mail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'97ba961f-df60-4838-955d-db07fc18e6d3', N'daniel@mail.com', 0, N'AM9tpy0vB++YeBeoV2pR+QsCZyBZJkHXDz/Tbrg2r5o0XkcYQg4WaYMc6ru/ej1tow==', N'cd9de46e-25a9-4083-8a60-c2469b19ef40', NULL, 0, 0, NULL, 1, 0, N'daniel@mail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'667db021-bc7f-4e76-9fef-ca9b288e2877', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8d63f7e6-c6c3-4c3d-af3f-b9f796446e77', N'667db021-bc7f-4e76-9fef-ca9b288e2877')

");
        }

        public override void Down()
        {
        }
    }
}
