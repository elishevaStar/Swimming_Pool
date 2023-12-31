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
        public List<Lesson> GetAllLessons()
        {
            return _lessonRepository.GetAllLessons();
        }

        public ActionResult<Lesson> GetLessonById(int id)
        {
            return _lessonRepository.GetLessonById(id);
        }


        public void AddLesson(Lesson less)
        {
            _lessonRepository.AddLesson(less);
        }

        public void UpdateLesson(int id, Lesson less)
        {
             _lessonRepository.UpdateLesson(id, less);
        }


        public void DeleteLesson(int id)
        {
             _lessonRepository.DeleteLesson(id);
        }
    }
}
