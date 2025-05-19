using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropNest.Domain.Interfaces
{
    public interface ICurrentUserService
    {
        string? UserEmail { get; }
        string? UserRole { get; }
        int? UserId { get; }
    }
}
