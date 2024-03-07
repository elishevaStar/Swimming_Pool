using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Presence>> GetAllPresencesAsync()
        {
            return await _context.Presences.ToListAsync();
        }

        public async Task<Presence> GetPresenceByIdAsync(int id)
        {
            return await _context.Presences.FindAsync(id);
            
        }

        public async Task<Presence> AddPresenceAsync(Presence p)
        {
            _context.Presences.Add(p);
            await _context.SaveChangesAsync();
            return p;
        }

        public async Task<Presence> UpdatePresenceAsync(int id, Presence p)
        {
            var pre =await GetPresenceByIdAsync(id);
            if (pre != null)
            {
                pre.LessonId = p.LessonId;
                pre.StudentId = p.StudentId;
                pre.IsPresent = p.IsPresent;
                await _context.SaveChangesAsync();
            }

            return pre;
        }
    }
}
