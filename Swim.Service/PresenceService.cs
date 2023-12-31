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

        public List<Presence> GetAllPresences()
        {
            return _presenceRepository.GetAllPresences();
        }

        public ActionResult<Presence> GetPresenceById(int idT, int idL, int idS)
        {
           return _presenceRepository.GetPresenceById(idT, idL, idS);
        }

        public void AddPresence(Presence p)
        {
            _presenceRepository.AddPresence(p);
        }

        public void UpdatePresence(int idT, int idL, int idS, Presence p)
        {
            _presenceRepository.UpdatePresence(idT, idL, idS, p);
        }
    }
}
