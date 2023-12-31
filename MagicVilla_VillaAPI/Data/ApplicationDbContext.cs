﻿using MagicVilla_VillaAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    id = 1,
                    name = "Royal Villa",
                    details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    imageUrl = "https://dotnetmastery.com/bluevillaimages/villa3.jpg",
                    occupancy = 4,
                    rate = 200,
                    sqft = 550,
                    amenity = "",
                    createdDate= DateTime.Now
                },
              new Villa
              {
                  id = 2,
                  name = "Premium Pool Villa",
                  details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                  imageUrl = "https://dotnetmastery.com/bluevillaimages/villa1.jpg",
                  occupancy = 4,
                  rate = 300,
                  sqft = 550,
                  amenity = "",
                  createdDate = DateTime.Now
              },
              new Villa
              {
                  id = 3,
                  name = "Luxury Pool Villa",
                  details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                  imageUrl = "https://dotnetmastery.com/bluevillaimages/villa4.jpg",
                  occupancy = 4,
                  rate = 400,
                  sqft = 750,
                  amenity = "",
                  createdDate = DateTime.Now
              },
              new Villa
              {
                  id = 4,
                  name = "Diamond Villa",
                  details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                  imageUrl = "https://dotnetmastery.com/bluevillaimages/villa5.jpg",
                  occupancy = 4,
                  rate = 550,
                  sqft = 900,
                  amenity = "",
                  createdDate = DateTime.Now
              },
              new Villa
              {
                  id = 5,
                  name = "Diamond Pool Villa",
                  details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                  imageUrl = "https://dotnetmastery.com/bluevillaimages/villa2.jpg",
                  occupancy = 4,
                  rate = 600,
                  sqft = 1100,
                  amenity = "",
                  createdDate = DateTime.Now
              });
        }
    }
}
