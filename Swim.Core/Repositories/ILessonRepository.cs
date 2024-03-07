
using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Core.Repositories
{
    public interface ILessonRepository
    {
        Task<List<Lesson>> GetAllLessonsAsync();

        Task<Lesson> GetLessonByIdAsync(int id);

        Task<Lesson> AddLessonAsync(Lesson l);

        Task<Lesson> UpdateLessonAsync(int id, Lesson l);

        Task DeleteLessonAsync(int id);

    }
}
