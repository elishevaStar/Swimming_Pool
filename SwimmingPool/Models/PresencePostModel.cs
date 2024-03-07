using Swim.Core.Entities;

namespace Swim.API.Models
{
    public class PresencePostModel
    {
        public bool IsPresent { get; set; }
        //public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public int LessonId { get; set; }
    }
}
