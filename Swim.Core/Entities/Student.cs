namespace Swim.Core.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? StudentFirstName { get; set; }
        public string? StudentLastName { get; set; }
        public string? Address { get; set; }
        public string StudentPhone { get; set; }
        public string ParentsPhone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? StudentEmail { get; set; }

        public bool StudentStatus { get; set; }
        public string? StudentStatusDescription { get; set; }
        //public Student( string StudentFirstName, string StudentLastName, string? Address, int StudentPhone, int ParentsPhone, DateOnly DateOfBirth, string? StudentEmail, bool StudentStatus, string? StudentStatusDescription)
        //{
        //    this.StudentId = StudentCount++;
        //    this.StudentFirstName = StudentFirstName;
        //    this.StudentLastName = StudentLastName;
        //    this.Address = Address;
        //    this.StudentPhone = StudentPhone;
        //    this.StudentStatus = StudentStatus;
        //    this.StudentStatusDescription = StudentStatusDescription;
        //    this.DateOfBirth = DateOfBirth;
        //    this.ParentsPhone = ParentsPhone;
        //    this.StudentEmail = StudentEmail;
        //}
        //public Student()
        //{

        //}
    }
}
