
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
    public interface ILessonService
    {
        Task<List<Lesson>> GetAllLessonsAsync();

        Task<Lesson> GetLessonByIdAsync(int id);

        Task AddLessonAsync(Lesson l);

        Task UpdateLessonAsync(int id, Lesson l);

        Task DeleteLessonAsync(int id);
    }
}
