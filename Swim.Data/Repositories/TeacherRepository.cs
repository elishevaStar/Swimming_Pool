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
    public class TeacherRepository : ITeacherRepository
    {
        private readonly DataContext _context;

        public TeacherRepository(DataContext context)
        {
            _context = context;
        }

        public List<Teacher> GetAllTeachers()
        {
            return _context.Teachers.ToList();
        }

        public Teacher GetTeacherById(int id)
        {
            return _context.Teachers.Find(id);
        }

        public Teacher AddTeacher(Teacher t)
        {
            _context.Teachers.Add(t);
            _context.SaveChanges();
            return t;
        }

        public Teacher UpdateTeacher(int id, Teacher t)
        {
            var teach = GetTeacherById(id);
            if (teach == null)
            {
                teach.TeacherHour = t.TeacherHour;
                teach.TeacherStatus = t.TeacherStatus;
                teach.TeacherPhone = t.TeacherPhone;
                teach.TeacherEmail = t.TeacherEmail;
                teach.TeacherAddress = t.TeacherAddress;
                teach.TeacherFirstName = t.TeacherFirstName;
                teach.TeacherLastName = t.TeacherLastName;
                teach.TeacherDays = t.TeacherDays;
                _context.SaveChanges();
            }

            return teach;
        }
        public void DeleteTeacher(int id)
        {
            var teach = GetTeacherById(id);
            _context.Teachers.Remove(teach);
            _context.SaveChanges();
        }
    }
}
