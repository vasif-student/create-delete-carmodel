using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.ViewModels
{
    public class CreateCommentViewModel
    {
        public string Text { get; set; }
        public int CarModelId { get; set; }
    }
}
