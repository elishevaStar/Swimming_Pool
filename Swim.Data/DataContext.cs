
using Microsoft.EntityFrameworkCore;
using Swim.Core.Entities;

namespace Swim.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Presence> Presences { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public int LessonCount = 1;
        public int StudentCount = 1;
        public int TeacherCount = 1;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=myswim_db");
        }

    }
}
