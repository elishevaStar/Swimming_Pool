using Swim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swim.Core;
using Swim.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Swim.Data.Repositories
{
    public class LessonRepository:ILessonRepository
    {
        private readonly DataContext _context;
        
        public LessonRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Lesson>> GetAllLessonsAsync()
        {
            return await _context.Lessons.ToListAsync();
        }

        public async Task<Lesson> GetLessonByIdAsync(int id)
        {
            return await _context.Lessons.FindAsync(id);
        }
        public async Task<Lesson> AddLessonAsync(Lesson less)
        {
            _context.Lessons.Add(less);
            await _context.SaveChangesAsync();
            return less;
        }

        public async Task<Lesson> UpdateLessonAsync(int id, Lesson less)
        {
            var lesson = await GetLessonByIdAsync(id);
            if (lesson != null)
            {
                lesson.LessonDescription = less.LessonDescription;
                lesson.LessonDate = less.LessonDate;
                lesson.TeacherId = less.TeacherId;
                await _context.SaveChangesAsync();
            }
            return lesson;
        }


        public async Task DeleteLessonAsync(int id)
        {
            var less = await GetLessonByIdAsync(id);
            _context.Lessons.Remove(less);
            await _context.SaveChangesAsync();
        }
    }
}
