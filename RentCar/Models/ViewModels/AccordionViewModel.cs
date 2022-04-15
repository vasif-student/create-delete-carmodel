using RentCar.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.ViewModels
{
    public class AccordionViewModel
    {
        public List<RentCar.Models.Entities.Car> Cars { get; set; }
        public List<CarModel> CarModels { get; set; }
        public List<City> Cities { get; set; }
    }
}
