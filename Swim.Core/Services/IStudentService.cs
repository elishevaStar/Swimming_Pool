using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Core.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();

        ActionResult<Student> GetStudentById(int id);

        void AddStudent(Student s);

        void UpdateStudent(int id, Student s);

        void DeleteStudent(int id);
    }
}
