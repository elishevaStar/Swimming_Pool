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
    public class PresenceService : IPresenceService
    {
        private readonly IPresenceRepository _presenceRepository;

        public PresenceService(IPresenceRepository presenceRepository)
        {
            _presenceRepository = presenceRepository;
        }

        public async Task<List<Presence>> GetAllPresencesAsync()
        {
            return await _presenceRepository.GetAllPresencesAsync();
        }

        public async Task<Presence> GetPresenceByIdAsync(int id)
        {
           return await _presenceRepository.GetPresenceByIdAsync(id);
        }

        public async Task AddPresenceAsync(Presence p)
        {
            await _presenceRepository.AddPresenceAsync(p);
        }

        public async Task UpdatePresenceAsync(int id, Presence p)
        {
            await _presenceRepository.UpdatePresenceAsync(id, p);
        }
    }
}
