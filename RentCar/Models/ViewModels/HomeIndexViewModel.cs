using RentCar.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.ViewModels
{
    public class HomeIndexViewModel
    {
        public ICollection<CarModel> CarModels { get; set; }
    }
}
