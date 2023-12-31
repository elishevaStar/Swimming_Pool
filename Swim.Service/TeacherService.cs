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
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public List<Teacher> GetAllTeachers()
        {
            return _teacherRepository.GetAllTeachers();
        }

        public ActionResult<Teacher> GetTeacherById(int id)
        {
           return _teacherRepository.GetTeacherById(id);
        }

        public void AddTeacher(Teacher t)
        {
            _teacherRepository.AddTeacher(t);
        }

        public void UpdateTeacher(int id, Teacher t)
        {
            _teacherRepository.UpdateTeacher(id, t);
        }
        public void DeleteTeacher(int id)
        {
            _teacherRepository.DeleteTeacher(id);
        }
    }
}
