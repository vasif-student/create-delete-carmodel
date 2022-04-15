using Microsoft.AspNetCore.Mvc;
using RentCar.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.ViewComponents
{
    public class CarouselViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public CarouselViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            return View(_dbContext.Sliders.ToList());
        }
    }
}
