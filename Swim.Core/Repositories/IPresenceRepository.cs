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
        List<Presence> GetAllPresences();

       Presence GetPresenceById(int idT, int idL, int idS);

        Presence AddPresence(Presence p);

        Presence UpdatePresence(int idT, int idL, int idS, Presence p);

    }
}
