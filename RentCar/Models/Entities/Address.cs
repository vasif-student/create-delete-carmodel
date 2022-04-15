using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.Entities
{
    public class Address : BaseEntity
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Mail { get; set; }
    }
}
