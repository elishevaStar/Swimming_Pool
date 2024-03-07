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
        Task<List<Teacher>> GetAllTeachersAsync();

        Task<Teacher> GetTeacherByIdAsync(int id);
        Teacher GetTeacherByUser(string userName, string password);

        Task<Teacher> AddTeacherAsync(Teacher t);

        Task<Teacher> UpdateTeacherAsync(int id, Teacher t);

        Task DeleteTeacherAsync(int id);
    }
}
