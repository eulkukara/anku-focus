using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AnkuFocus.Models;

namespace AnkuFocus.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<StudyRoom> StudyRooms { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<StudySession> StudySessions { get; set; }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
    }
}