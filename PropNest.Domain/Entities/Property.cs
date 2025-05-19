using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropNest.Domain.Entities
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Address { get; set; } = null!;
        public decimal Quadrature { get; set; }
        public int NumberOfRooms { get; set; }
        public decimal Price { get; set; }
        public int YearBuilt { get; set; }
        public bool IsFurnished { get; set; }
        public PropertyType PropertyType { get; set; } = null!;
        public PropertyStatus Status { get; set; } = null!;
        public int OwnerId { get; set; }
        public User Owner { get; set; } = null!;
        public int? CurrencyId { get; set; }
        public Currency? Currency { get; set; }
        public ICollection<Location> Locations { get; set; } = new List<Location>();
        public ICollection<Liked> Likes { get; set; } = new List<Liked>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public ICollection<File> Files { get; set; } = new List<File>();
    }
}
