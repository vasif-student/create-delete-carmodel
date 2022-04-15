using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.Entities
{
    public class RentedCar : BaseEntity
    {
        public int CarModelId { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public CarModel CarModel { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
