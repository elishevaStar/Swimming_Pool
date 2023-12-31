
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
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=swim_db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Presence>().HasKey(p => new { p.TeacherId, p.StudentId, p.LessonId });
        }

        //public DataContext()
        //{
        //    Lessons = new List<Lesson>();
        //    Presences = new List<Presence>();
        //    Students = new List<Student>();
        //    Teachers= new List<Teacher>();
        //    Students.Add(new Student { StudentId = StudentCount++, StudentFirstName = "elish", StudentLastName = "katz", Address = "Sorotzkin4", StudentPhone = "0504153454", ParentsPhone = "0504153089", DateOfBirth = DateTime.Now, StudentEmail = "elishstar1@gmail.com", StudentStatus = true, StudentStatusDescription = "שחיה חופשית" });
        //    Teachers.Add(new Teacher { TeacherId = TeacherCount++, TeacherFirstName = "malka", TeacherLastName = "brok", TeacherAddress = "kriatHertzog", TeacherPhone = "0527603743", TeacherEmail = "mabrok@gmail.com", TeacherStatus = true, TeacherDays = DayOfWeek.Monday,  TeacherHour = DateTime.Now });
        //    Teachers.Add(new Teacher { TeacherId = TeacherCount++, TeacherFirstName = "hadasa", TeacherLastName = "coen", TeacherAddress = "chavakok", TeacherPhone = "035732865", TeacherEmail = "hadsac@gmail.com", TeacherStatus = true,TeacherDays=DayOfWeek.Sunday,TeacherHour = DateTime.Now });
        //    Lessons.Add(new Lesson { LessonId = LessonCount++, LessonDescription = "שיפור שחיה", LessonHour = DateTime.Now, TeacherId = 1 });
        //    Lessons.Add(new Lesson { LessonId = LessonCount++, LessonDescription = "שחיה מתחילות", LessonHour = DateTime.Now, TeacherId = 2 });
        //    Presences.Add(new Presence { LessonId = 1, TeacherId = 1, StudentId = 1, IsPresent = true });

        //}
    }
}
