using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.Entities
{
    public class PartnerInfoCard : BaseEntity
    {
        public string Image { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
    }
}
