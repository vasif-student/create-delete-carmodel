using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Areas.Admin.Models.ViewModel
{
    public class PhotoCreateViewModel
    {
        public IFormFile[] Files { get; set; }
        public int CarModelId { get; set; }
    }
}
