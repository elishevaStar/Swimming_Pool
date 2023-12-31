
using Microsoft.AspNetCore.Mvc;
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
        List<Lesson> GetAllLessons();

        ActionResult<Lesson> GetLessonById(int id);

        void AddLesson(Lesson l);

        void UpdateLesson(int id, Lesson l);

        void DeleteLesson(int id);
    }
}
