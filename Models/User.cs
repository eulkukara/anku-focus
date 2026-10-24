using System.ComponentModel.DataAnnotations;

namespace AnkuFocus.Models
{
    public class User
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Kullanıcı adı zorunludur.")]
        [StringLength(50)]
        public string Username { get; set; } = "";
        
        [Required(ErrorMessage = "E-posta zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; } = "";
        
        public string PasswordHash { get; set; } = "";
        
        [Display(Name = "Ad Soyad")]
        public string FullName { get; set; } = "";
        
        [Display(Name = "Bölüm")]
        public string Department { get; set; } = "";
        
        public string Role { get; set; } = "Student"; // Admin veya Student
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}