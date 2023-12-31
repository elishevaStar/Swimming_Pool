namespace Swim.Core.Entities
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string? TeacherFirstName { get; set; }
        public string? TeacherLastName { get; set; }
        public string? TeacherAddress { get; set; }
        public string TeacherPhone { get; set; }
        public string? TeacherEmail { get; set; }
        public bool TeacherStatus { get; set; }
        public DayOfWeek TeacherDays { get; set; }
        public DateTime TeacherHour { get; set; }

        //public Teacher()
        //{

        //}
        //public Teacher( string? TeacherFirstName, string? TeacherLastName, string? TeacherAddress, int TeacherPhone, string? TeacherEmail, bool TeacherStatus, TimeOnly Hour, Enum Days)
        //{
        //    this.TeacherId = TeacherCount++;
        //    this.TeacherHour = Hour;
        //    this.TeacherPhone = TeacherPhone;
        //    this.TeacherStatus = TeacherStatus;
        //    this.TeacherAddress = TeacherAddress;
        //    this.TeacherFirstName = TeacherFirstName;
        //    this.TeacherEmail = TeacherEmail;
        //    this.TeacherPhone = TeacherPhone;
        //    this.TeacherDays = Days;
        //}
    }
}
