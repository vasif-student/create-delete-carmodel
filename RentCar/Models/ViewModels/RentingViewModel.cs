using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.ViewModels
{
    public class RentingViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CarModelId { get; set; }
        public string UserId { get; set; }
    }
}
