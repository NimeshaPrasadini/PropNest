using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropNest.Domain.Entities
{
    public class File
    {
        public int Id { get; set; }
        public int? PropertyId { get; set; }
        public Property? Property { get; set; }
        public byte[]? ImageData { get; set; }
        public string? FileName { get; set; }
        public string? Path { get; set; }
    }
}
