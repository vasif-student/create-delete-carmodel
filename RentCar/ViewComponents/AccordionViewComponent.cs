using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentCar.DAL;
using RentCar.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.ViewComponents
{
    public class AccordionViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public AccordionViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            var cars = _dbContext.Cars.ToList();
            var carModels = _dbContext.CarModels.ToList();
            var cities = _dbContext.Cities.ToList();

            return View(new AccordionViewModel { 
                Cars = cars,
                CarModels = carModels,
                Cities = cities
            });
        }
    }
}
