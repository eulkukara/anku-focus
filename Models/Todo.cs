using System.ComponentModel.DataAnnotations;

namespace AnkuFocus.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        public User? User { get; set; }

        [Required(ErrorMessage = "Başlık zorunludur.")]
        [StringLength(100)]
        public string Title { get; set; } = "";

        [StringLength(500)]
        public string? Description { get; set; }

        public bool IsCompleted { get; set; } = false;

        public DateTime? DueDate { get; set; }
    }
}