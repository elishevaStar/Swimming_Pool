using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using Swim.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Data.Repositories
{
    public class PresenceRepository : IPresenceRepository
    {
        private readonly DataContext _context;

        public PresenceRepository(DataContext context)
        {
            _context = context;
        }

        public List<Presence> GetAllPresences()
        {
            return _context.Presences.ToList();
        }

        public Presence GetPresenceById(int idT, int idL, int idS)
        {
            return _context.Presences.ToList().Find(p => p.TeacherId == idT && p.StudentId == idS && p.LessonId == idL);
            
        }

        public Presence AddPresence(Presence p)
        {
            _context.Presences.Add(p);
            _context.SaveChanges();
            return p;
        }

        public Presence UpdatePresence(int idT, int idL, int idS, Presence p)
        {
            var pre = GetPresenceById(idT, idL, idS);
            if (pre != null)
            {
                pre.LessonId = p.LessonId;
                pre.StudentId = p.StudentId;
                pre.IsPresent = p.IsPresent;
                pre.TeacherId = p.TeacherId;
            }

            return pre;
        }
    }
}
