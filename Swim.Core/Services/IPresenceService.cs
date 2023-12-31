using Microsoft.AspNetCore.Mvc;
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
        List<Presence> GetAllPresences();

        ActionResult<Presence> GetPresenceById(int idT, int idL, int idS);

        void AddPresence(Presence p);

        void UpdatePresence(int idT, int idL, int idS, Presence p);
    }
}
