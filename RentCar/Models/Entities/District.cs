using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.Entities
{
    public class District : BaseEntity
    {
        public string Name { get; set; }
        public City City { get; set; }
        public ICollection<CarModel> carModels { get; set; }
    }
}
