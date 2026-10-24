using System.ComponentModel.DataAnnotations;

namespace AnkuFocus.Models
{
    public class Tag
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Etiket adı zorunludur.")]
        [StringLength(50)]
        public string Name { get; set; } = "";

        [StringLength(7)] 
        public string ColorCode { get; set; } = "#000000"; // Örn: #FF5733

        // Bu etikete sahip çalışma oturumları
        public List<StudySession> StudySessions { get; set; } = new();
    }
}