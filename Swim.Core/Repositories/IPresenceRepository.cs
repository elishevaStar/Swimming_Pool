using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Core.Repositories
{
    public interface IPresenceRepository
    {
        Task<List<Presence>> GetAllPresencesAsync();

        Task<Presence> GetPresenceByIdAsync(int id);

        Task<Presence> AddPresenceAsync(Presence p);

        Task<Presence> UpdatePresenceAsync(int id, Presence p);

    }
}
