﻿namespace Swim.Core.Entities
{
    public class Teacher:BaseModel
    {
        public string? TeacherFirstName { get; set; }
        public string? TeacherLastName { get; set; }
        public string? TeacherAddress { get; set; }
        public string TeacherPhone { get; set; }
        public string? TeacherEmail { get; set; }
        public bool TeacherStatus { get; set; }
        public DayOfWeek TeacherDays { get; set; }
        public DateTime TeacherHour { get; set; }

        //יחיד לרבים
        public List<Lesson> Lessons { get; set; }
    }
}
