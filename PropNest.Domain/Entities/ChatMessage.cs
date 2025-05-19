using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropNest.Domain.Entities
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public User? Sender { get; set; }
        public int ChatRoomId { get; set; }
        public ChatRoom? ChatRoom { get; set; }
        public string? Body { get; set; }
        public bool IsRead { get; set; }
        public DateTime TimeStamp { get; set; }
    }

}
