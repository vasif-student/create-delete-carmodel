using Microsoft.AspNetCore.Identity;
using RentCar.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Data
{
    public class DataInitializer
    {
        private readonly AppDbContext _dbContext;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DataInitializer(AppDbContext dbContext, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _roleManager = roleManager;
        }

        public async Task SeedData()
        {
            if (!_dbContext.Roles.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole("Admin"));
                await _roleManager.CreateAsync(new IdentityRole("Moderator"));
                await _roleManager.CreateAsync(new IdentityRole("User"));
            }
        }
    }
}
