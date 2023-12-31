using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using Swim.Core.Repositories;
using Swim.Core.Services;
using Swim.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        public ActionResult<Student> GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }

        public void AddStudent(Student s)
        {
            _studentRepository.AddStudent(s);
        }

        public void UpdateStudent(int id, Student s)
        {
            _studentRepository.UpdateStudent(id, s);
        }
        public void DeleteStudent(int id)
        {
            _studentRepository.DeleteStudent(id);
        }
    }
}
