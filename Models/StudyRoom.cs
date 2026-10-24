using System.ComponentModel.DataAnnotations;

namespace AnkuFocus.Models
{
    public class StudyRoom
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Oda adı zorunludur.")]
        [StringLength(100)]
        public string Name { get; set; } = "";

        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        public string RoomType { get; set; } = "Pomodoro"; // Pomodoro veya Timer

        [Range(1, 50, ErrorMessage = "Katılımcı sayısı 1 ile 50 arasında olmalıdır.")]
        public int MaxParticipants { get; set; } = 10;

        public string AccessType { get; set; } = "Public"; // Public veya Private
        
        [StringLength(20)]
        public string? InviteCode { get; set; }

        // Bire-Çok İlişki (Bir kullanıcının kurduğu oda)
        public int CreatorId { get; set; }
        public User? Creator { get; set; }

        // Bu odadaki çalışma oturumları (İleride ekleyeceğiz)
        public List<StudySession> StudySessions { get; set; } = new();
    }
}