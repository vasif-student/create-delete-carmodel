using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.Entities
{
    public class Comment : BaseEntity
    {
        public string UserName { get; set; }
        public int CarModelId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Text { get; set; }
        public string? Image { get; set; } = "profile-pic.jpg";
    }
}
