using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.Entities
{
    public class Car : BaseEntity
    {
        public string BrandName { get; set; }
        public string Website { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public ICollection<CarModel> CarModels { get; set; }

    }
}
