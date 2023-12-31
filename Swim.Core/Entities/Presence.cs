namespace Swim.Core.Entities
{
    public class Presence
    {
        public int LessonId { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public bool IsPresent { get; set; }
        public Presence() { }
        public Presence(int LessonId, int TeacherId, int StudentId, bool IsPresent) {
            this.LessonId = LessonId;
            this.TeacherId = TeacherId;
            this.StudentId = StudentId;
            this.IsPresent = IsPresent;
        }

    }
}
