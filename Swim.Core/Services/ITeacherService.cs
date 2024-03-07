using Microsoft.AspNetCore.Mvc;
using Swim.Core.DTOs;
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
        Task<List<Teacher>> GetAllTeachersAsync();

        Task<Teacher> GetTeacherByIdAsync(int id);
        public Teacher GetTeacherByUser(string userName, string password);
        Task AddTeacherAsync(Teacher t);

        Task UpdateTeacherAsync(int id, Teacher t);

        Task DeleteTeacherAsync(int id);
    }
}
