using Microsoft.AspNetCore.Mvc;
using Swim.Core.DTOs;
using Swim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Core.Services
{
    public interface IPresenceService
    {
        Task<List<Presence>> GetAllPresencesAsync();

        Task<Presence> GetPresenceByIdAsync(int id);

        Task AddPresenceAsync(Presence p);

        Task UpdatePresenceAsync(int id, Presence p);
    }
}
