using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentCar.DAL;
using RentCar.Models.Entities;
using RentCar.Models.ViewModels;
using RentCar.Models.ViewModels.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(new HomeIndexViewModel { 
                CarModels = await _dbContext.CarModels.Where(c => !c.IsDeleted)
                .Include(c => c.Car)
                .Include(c => c.District).ThenInclude(d => d.City)
                .Include(c => c.CarImages.Where(i => i.IsMain))
                .Take(4).Where(c => c.Rating > 2).ToListAsync()
            });
        }

        //***** LoadMore *****//
        public async Task<IActionResult> LoadMore(int skipCount)
        {
            var carModels = await _dbContext.CarModels.Where(c => !c.IsDeleted)
                .Skip(skipCount).Take(4).Include(c => c.Car)
                .Include(c => c.District).ThenInclude(d => d.City)
                .Include(c => c.CarImages.Where(i => i.IsMain))
                .ToListAsync();

            return PartialView("_CarModelPartial", new HomeIndexViewModel { CarModels = carModels});
        }

        //***** Search *****//
        public async Task<IActionResult> SearchCar(CarSearchViewModel model)
        {
            
            
            var carModels = await _dbContext.CarModels.Where(c => !c.IsDeleted && c.ModelName == model.CarModelName
            && c.District.City.Name == model.CityName && (c.CurrentPrice > model.MinPrice && c.CurrentPrice < model.MaxPrice))
                .Include(c => c.Car)
                .Include(c => c.District).ThenInclude(d => d.City)
                .Include(c => c.CarImages.Where(i => i.IsMain))
                .ToListAsync();
                
            
            List<CarModel> searchedCarList = new List<CarModel>();

            var rentedCars = await _dbContext.RentedCars.ToListAsync();
                        
            //foreach (var carModel in carModels)
            //{
            //    foreach (var rentedCar in rentedCars)
            //    {
            //        if (carModel.Id == rentedCar.CarModelId)
            //        {
            //            if ((model.StartDate < rentedCar.StartDate || model.StartDate > rentedCar.EndDate) &&
            //                ((model.EndDate < rentedCar.StartDate || model.EndDate > rentedCar.EndDate)) 
            //                && model.EndDate > model.StartDate)
            //            {
            //                searchedCarList.Add(carModel);
            //            }
            //        }
            //        else
            //        {
            //            searchedCarList.Add(carModel);
            //        }
            //    }

            //}



            return View(carModels);

        }

    }
}
