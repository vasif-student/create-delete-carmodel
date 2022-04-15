using Microsoft.AspNetCore.Http;
using RentCar.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Areas.Admin.Models.ViewModel
{
    public class CarCreateViewModel
    {
        public List<Car> Cars { get; set; }
        public List<CarModel> CarModels { get; set; }
        public List<City> Cities { get; set; }
        public List<District> Districts { get; set; }
        public string CarBrandName { get; set; }
        public string CarModelName { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public byte Rating { get; set; }
        public ushort ReleaseYear { get; set; }
        public string Color { get; set; }
        public float EngineSize { get; set; }
        public ushort HorsePower { get; set; }
        public string Fuel { get; set; }
        public uint MileAge { get; set; }
        public string Transmission { get; set; }
        public IFormFile[] Files { get; set; }
    }
}
