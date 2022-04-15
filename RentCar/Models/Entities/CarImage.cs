using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.Entities
{
    public class CarImage : BaseEntity
    {
        public string ImageName { get; set; }
        public int CarModelId { get; set; }
        public CarModel CarModel { get; set; }
        public bool IsMain { get; set; } = false;
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
