using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using Swim.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;

        public StudentRepository(DataContext context)
        {
            _context = context;
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.Find(id);
        }

        public Student AddStudent(Student s)
        {
            _context.Students.Add(s);
            _context.SaveChanges();
            return s;
        }

        public Student UpdateStudent(int id, Student s)
        {
            var st = GetStudentById(id);
           if(st == null)
           {
                st.StudentEmail = s.StudentEmail;
                st.StudentStatus = s.StudentStatus;
                st.StudentPhone = s.StudentPhone;
                st.StudentLastName = s.StudentLastName;
                st.DateOfBirth = s.DateOfBirth;
                st.StudentPhone = s.StudentPhone; ;
                st.ParentsPhone = s.ParentsPhone;
                st.StudentFirstName = s.StudentFirstName;
                st.StudentStatusDescription = s.StudentStatusDescription;
                _context.SaveChanges();

            }
            
            return st;
        }
        public void DeleteStudent(int id)
        {
            var s = GetStudentById(id);
            _context.Students.Remove(s);
            _context.SaveChanges();
        }
    }
}
