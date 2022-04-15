using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.ViewModels.Car
{
    public class CarSearchViewModel
    {
        public string CarBrandName { get; set; }
        public string CarModelName { get; set; }
        public string CityName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float MinPrice { get; set; }
        public float MaxPrice { get; set; }
    }
}
