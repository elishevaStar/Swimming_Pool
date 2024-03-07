using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Core.DTOs
{
    public class StudentDto
    {
        public string StudentTz { get; set; }
        public string? StudentFirstName { get; set; }
        public string? StudentLastName { get; set; }
        public string? Address { get; set; }
        public string StudentPhone { get; set; }
        public string ParentsPhone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? StudentEmail { get; set; }
        public bool StudentStatus { get; set; }
        public string? StudentStatusDescription { get; set; }
    }
}
