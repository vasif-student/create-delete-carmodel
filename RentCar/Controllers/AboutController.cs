using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentCar.DAL;
using RentCar.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _dbContext;

        public AboutController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(new AboutIndexViewModel { 
                AboutSection = await _dbContext.AboutSections.FirstOrDefaultAsync()
            });
        }
    }
}
