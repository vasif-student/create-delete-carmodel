using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.Entities
{
    public class CarModel : BaseEntity
    {
        public string ModelName { get; set; }
        public District District { get; set; }
        public string Description { get; set; }
        public float OldPrice { get; set; } = 0;
        public float CurrentPrice { get; set; }
        public byte Rating { get; set; } = 3;
        public ushort ReleaseYear { get; set; }
        public string Color { get; set; }
        public float EngineSize { get; set; }
        public ushort HorsePower { get; set; }
        public string Fuel { get; set; }
        public uint MileAge { get; set; }
        public string Transmission { get; set; }
        public string? OwnerId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Car Car { get; set; }
        public ICollection<CarImage> CarImages { get; set; }

    }
}
