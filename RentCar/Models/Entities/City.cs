using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<District> Districts { get; set; }
    }
}
