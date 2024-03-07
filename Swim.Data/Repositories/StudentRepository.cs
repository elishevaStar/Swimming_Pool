using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task<Student> AddStudentAsync(Student s)
        {
            _context.Students.Add(s);
            await _context.SaveChangesAsync();
            return s;
        }

        public async Task<Student> UpdateStudentAsync(int id, Student s)
        {
            var st = await GetStudentByIdAsync(id);
           if(st != null)
           {
                st.StudentTz = s.StudentTz;
                st.StudentEmail = s.StudentEmail;
                st.StudentStatus = s.StudentStatus;
                st.StudentPhone = s.StudentPhone;
                st.StudentLastName = s.StudentLastName;
                st.DateOfBirth = s.DateOfBirth;
                st.StudentPhone = s.StudentPhone; ;
                st.ParentsPhone = s.ParentsPhone;
                st.StudentFirstName = s.StudentFirstName;
                st.StudentStatusDescription = s.StudentStatusDescription;
                await _context.SaveChangesAsync();

           }
            
            return st;
        }
        public async Task DeleteStudentAsync(int id)
        {
            var s = await GetStudentByIdAsync(id);
            _context.Students.Remove(s);
            await _context.SaveChangesAsync();
        }
    }
}
