
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Swim.Core.Entities;

namespace Swim.Data
{
    public class DataContext: DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Presence> Presences { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public int LessonCount = 1;
        public int StudentCount = 1;
        public int TeacherCount = 1;

        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration["ConnectionString"]);
        }

    }
}
