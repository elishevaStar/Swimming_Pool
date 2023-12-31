using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Core.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();

        Student GetStudentById(int id);

        Student AddStudent(Student s);

        Student UpdateStudent(int id, Student s);

        void DeleteStudent(int id);
    }
}
