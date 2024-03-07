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
    public class TeacherRepository : ITeacherRepository
    {
        private readonly DataContext _context;

        public TeacherRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Teacher>> GetAllTeachersAsync()
        {
            return await _context.Teachers.ToListAsync();
        }

        public async Task<Teacher> GetTeacherByIdAsync(int id)
        {
            return await _context.Teachers.FindAsync(id);
        }

        public Teacher GetTeacherByUser(string userName, string password)

        {
            return _context.Teachers.Where(t=>t.TeacherFirstName== userName && t.TeacherEmail== password).FirstOrDefault();
        }

        public async Task<Teacher> AddTeacherAsync(Teacher t)
        {
            _context.Teachers.Add(t);
            await _context.SaveChangesAsync();
            return t;
        }

        public async Task<Teacher> UpdateTeacherAsync(int id, Teacher t)
        {
            var teach = await GetTeacherByIdAsync(id);
            if (teach != null)
            {
                teach.TeacherHour = t.TeacherHour;
                teach.TeacherStatus = t.TeacherStatus;
                teach.TeacherPhone = t.TeacherPhone;
                teach.TeacherEmail = t.TeacherEmail;
                teach.TeacherAddress = t.TeacherAddress;
                teach.TeacherFirstName = t.TeacherFirstName;
                teach.TeacherLastName = t.TeacherLastName;
                teach.TeacherDays = t.TeacherDays;
                await _context.SaveChangesAsync();
            }

            return teach;
        }
        public async Task DeleteTeacherAsync(int id)
        {
            var teach =await GetTeacherByIdAsync(id);
            _context.Teachers.Remove(teach);
            await _context.SaveChangesAsync();
        }
    }
}
