using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.Entities
{
    public class AboutSection : BaseEntity
    {
        public string HeaderImage { get; set; }
        public string HeaderTitle { get; set; }
        public string SideImage { get; set; }
        public string Video { get; set; }
        public string ForMoreDetails { get; set; }
        public string News { get; set; }
    }
}
