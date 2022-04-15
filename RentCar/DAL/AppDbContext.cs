using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentCar.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.DAL
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Logo> Logos { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<PartnerInfoCard> PartnerInfoCards { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AboutSection> AboutSections { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<RentedCar> RentedCars { get; set; }
    }
}
