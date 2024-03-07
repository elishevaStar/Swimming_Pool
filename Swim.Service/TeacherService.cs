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

        public async Task<List<Teacher>> GetAllTeachersAsync()
        {
            return await _teacherRepository.GetAllTeachersAsync();
        }

        public async Task<Teacher> GetTeacherByIdAsync(int id)
        {
           return await _teacherRepository.GetTeacherByIdAsync(id);
        }

        public Teacher GetTeacherByUser(string userName, string password)
        {
            return _teacherRepository.GetTeacherByUser(userName, password);
        }

        public async Task AddTeacherAsync(Teacher t)
        {
            await _teacherRepository.AddTeacherAsync(t);
        }

        public async Task UpdateTeacherAsync(int id, Teacher t)
        {
            await _teacherRepository.UpdateTeacherAsync(id, t);
        }
        public async Task DeleteTeacherAsync(int id)
        {
            await _teacherRepository.DeleteTeacherAsync(id);
        }
    }
}
