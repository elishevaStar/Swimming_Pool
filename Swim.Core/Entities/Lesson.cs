namespace Swim.Core.Entities
{
    public class Lesson:BaseModel
    {
        
        public string? LessonDescription { get; set; }
        public DateTime LessonDate { get; set; }

        //יחיד לרבים
        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }
        //יחיד לרבים
        public List<Presence> Presences { get; set; }




    }
}
