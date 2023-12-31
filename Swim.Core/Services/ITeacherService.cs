using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Core.Services
{
    public interface ITeacherService
    {
        List<Teacher> GetAllTeachers();

        ActionResult<Teacher> GetTeacherById(int id);

        void AddTeacher(Teacher t);

        void UpdateTeacher(int id, Teacher t);

        void DeleteTeacher(int id);
    }
}
