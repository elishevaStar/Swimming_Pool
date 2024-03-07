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
    public class LessonService : ILessonService
    {
        private readonly ILessonRepository _lessonRepository;

        public LessonService(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }
        public async Task<List<Lesson>> GetAllLessonsAsync()
        {
            return await _lessonRepository.GetAllLessonsAsync();
        }

        public async Task<Lesson> GetLessonByIdAsync(int id)
        {
            return await _lessonRepository.GetLessonByIdAsync(id);
        }


        public async Task AddLessonAsync(Lesson less)
        {
           await _lessonRepository.AddLessonAsync(less);
        }

        public async Task UpdateLessonAsync(int id, Lesson less)
        {
            await  _lessonRepository.UpdateLessonAsync(id, less);
        }


        public async Task DeleteLessonAsync(int id)
        {
             await _lessonRepository.DeleteLessonAsync(id);
        }
    }
}
