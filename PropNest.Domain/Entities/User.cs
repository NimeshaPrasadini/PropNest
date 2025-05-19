using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PropNest.Domain.Entities
{
    public class User : IdentityUser<int>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? AboutMe { get; set; }
        public byte[]? ProfilePicture { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletionDate { get; set; }
        public DateTime CreationDate { get; set; }
        public ICollection<Property>? Properties { get; set; }
        public ICollection<Liked>? Watchlists { get; set; }
        public ICollection<ChatRoom>? Conversations { get; set; }
        public ICollection<ChatMessage>? ChatMessages { get; set; }
        public ICollection<Review>? LeavedReviews { get; set; }
        public ICollection<Booking>? Bookings { get; set; }
        public ICollection<ChatRoom>? SellerConversations { get; set; }
        public ICollection<ChatRoom>? BuyerConversations { get; set; }
    }

}
