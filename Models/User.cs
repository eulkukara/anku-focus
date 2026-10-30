using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity; 

namespace AnkuFocus.Models
{
    
    public class User : IdentityUser<int>
    {
    
        [Display(Name = "Ad Soyad")]
        public string FullName { get; set; } = "";
        
        [Display(Name = "Bölüm")]
        public string Department { get; set; } = "";
        
        public string Role { get; set; } = "Student"; // Admin veya Student
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}