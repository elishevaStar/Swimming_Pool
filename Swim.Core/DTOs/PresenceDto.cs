using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Core.DTOs
{
    public class PresenceDto
    {
        public bool IsPresent { get; set; }
        //public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public int LessonId { get; set; }
    }
}
