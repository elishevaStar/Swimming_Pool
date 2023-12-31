using Swim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swim.Core;
using Swim.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Swim.Data.Repositories
{
    public class LessonRepository:ILessonRepository
    {
        private readonly DataContext _context;
        
        public LessonRepository(DataContext context)
        {
            _context = context;
        }
        public List<Lesson> GetAllLessons()
        {
            return _context.Lessons.ToList();
        }

        public Lesson GetLessonById(int id)
        {
            return _context.Lessons.Find(id);
        }


        public Lesson AddLesson(Lesson less)
        {
            _context.Lessons.Add(less);
            _context.SaveChanges();
            return less;
        }

        public Lesson UpdateLesson(int id, Lesson less)
        {
            var lesson = GetLessonById(id);
            if (lesson != null)
            {
                lesson.LessonDescription = less.LessonDescription;
                lesson.LessonHour = less.LessonHour;
                lesson.TeacherId = less.TeacherId;
                _context.SaveChanges();
            }
            return lesson;
        }


        public void DeleteLesson(int id)
        {
            var less = GetLessonById(id);
            _context.Lessons.Remove(less);
            _context.SaveChanges();
        }
    }
}
