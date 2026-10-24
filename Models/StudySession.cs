using System.ComponentModel.DataAnnotations;

namespace AnkuFocus.Models
{
    public class StudySession
    {
        public int Id { get; set; }

        // Hangi kullanıcı çalıştı? (Bire-Çok İlişki)
        [Required]
        public int UserId { get; set; }
        public User? User { get; set; }

        // Hangi odada çalıştı? (Bireysel çalıştıysa boş kalabilir)
        public int? StudyRoomId { get; set; }
        public StudyRoom? StudyRoom { get; set; }

        // Hangi derse/etikete çalıştı? (Boş kalabilir)
        public int? TagId { get; set; }
        public Tag? Tag { get; set; }

        [Range(1, 1440, ErrorMessage = "Süre 1 ile 1440 dakika arasında olmalıdır.")]
        public int DurationMinutes { get; set; }

        public DateTime StartTime { get; set; } = DateTime.UtcNow;
        
        public DateTime? EndTime { get; set; }
    }
}