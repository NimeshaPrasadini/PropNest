using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropNest.Domain.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public int PropertyId { get; set; }
        public Property? Property { get; set; }
    }
}
