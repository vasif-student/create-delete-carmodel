using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Xana boş olmamalıdır"), EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Xana boş olmamalıdır"), DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
