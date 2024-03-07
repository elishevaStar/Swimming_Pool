using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Core.DTOs
{
    public class LessonDto
    {
        public string? LessonDescription { get; set; }
        public DateTime LessonDate { get; set; }
        public int TeacherId { get; set; }
    }
}
