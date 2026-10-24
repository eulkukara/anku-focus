using Microsoft.EntityFrameworkCore;
using AnkuFocus.Models;

namespace AnkuFocus.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<StudyRoom> StudyRooms { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<StudySession> StudySessions { get; set; }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
    }
}