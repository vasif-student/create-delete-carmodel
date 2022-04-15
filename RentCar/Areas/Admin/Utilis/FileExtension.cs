using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Areas.Admin.Utilis
{
    public static class FileExtension
    {
        public static bool IsSupported(this IFormFile file)
        {
            return file.ContentType.Contains("image");
        }

        public static bool IsGreaterThanGivenSize(this IFormFile file, int kb)
        {
            return file.Length > kb * 1000;
        }
    }
}
