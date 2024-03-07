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
    public interface IStudentService
    {
        Task<List<Student>> GetAllStudentsAsync();

        Task<Student> GetStudentByIdAsync(int id);

        Task AddStudentAsync(Student s);

        Task UpdateStudentAsync(int id, Student s);

        Task DeleteStudentAsync(int id);
    }
}
