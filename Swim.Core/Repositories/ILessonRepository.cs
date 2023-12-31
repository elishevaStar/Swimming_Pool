
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
        List<Lesson> GetAllLessons();

        Lesson GetLessonById(int id);

        Lesson AddLesson(Lesson l);

        Lesson UpdateLesson(int id, Lesson l);

        void DeleteLesson(int id);

    }
}
