namespace Swim.Core.Entities
{
    public class Lesson
    {
        //public Lesson() { }
        public int LessonId { get; set; }
        public string? LessonDescription { get; set; }
        public DateTime LessonHour { get; set; }
        public int TeacherId { get; set; }

        //public Lesson( string? LessonDescription, TimeOnly LessonHour, int TeacherId)
        //{
        //    this.LessonId =LessonCount++;
        //    this.LessonDescription = LessonDescription;
        //    this.LessonHour = LessonHour;
        //    this.TeacherId = TeacherId;
        //}


    }
}
