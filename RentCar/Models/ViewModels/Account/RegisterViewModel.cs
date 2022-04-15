using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.ViewModels.Account
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Xana boş olmamalıdır"), MaxLength(100), MinLength(6)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Xana boş olmamalıdır"), EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Xana boş olmamalıdır"), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Xana boş olmamalıdır"), DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
