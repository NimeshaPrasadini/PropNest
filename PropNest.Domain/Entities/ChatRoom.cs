using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropNest.Domain.Entities
{
    public class ChatRoom
    {
        public int Id { get; set; }
        public int BuyerId { get; set; }
        public User? Buyer { get; set; }
        public int SellerId { get; set; }
        public User? Seller { get; set; }
        public int PropertyId { get; set; }
        public Property? Property { get; set; }
        public ICollection<ChatMessage>? ChatMessages { get; set; }
    }
}
