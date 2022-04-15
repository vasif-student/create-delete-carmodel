using RentCar.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.ViewModels.Car
{
    public class CarDetailViewModel
    {
        public CarModel CarModel { get; set; }
        public List<Comment> Comments { get; set; }
        public string[] ImageNames { get; set; }
    }
}
