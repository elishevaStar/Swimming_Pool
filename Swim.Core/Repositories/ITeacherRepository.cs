using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Core.Repositories
{
    public interface ITeacherRepository
    {
        List<Teacher> GetAllTeachers();

        Teacher GetTeacherById(int id);

        Teacher AddTeacher(Teacher t);

        Teacher UpdateTeacher(int id, Teacher t);

        void DeleteTeacher(int id);
    }
}
