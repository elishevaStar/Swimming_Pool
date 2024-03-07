namespace Swim.Core.Entities
{
    public class Presence:BaseModel
    {
        public bool IsPresent { get; set; }
        //public int TeacherId { get; set; }

        //יחיד לרבים
        public int StudentId { get; set; }

        public Student Student { get; set; }

        //יחיד לרבים
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }

        

    }
}
