using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Core.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllStudentsAsync();

        Task<Student> GetStudentByIdAsync(int id);

        Task<Student> AddStudentAsync(Student s);

        Task<Student> UpdateStudentAsync(int id, Student s);

        Task DeleteStudentAsync(int id);
    }
}
