using System.ComponentModel.DataAnnotations;

namespace AnkuFocus.Models
{
    public class Friendship
    {
        public int Id { get; set; }

        [Required]
        public int SenderUserId { get; set; }
        public User? SenderUser { get; set; }

        [Required]
        public int ReceiverUserId { get; set; }
        public User? ReceiverUser { get; set; }

        public string Status { get; set; } = "Pending"; // Pending, Accepted, Blocked
    }
}