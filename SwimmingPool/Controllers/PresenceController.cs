using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using Swim.Core.Services;
using Swim.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Swim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresenceController : ControllerBase
    {
        private readonly IPresenceService _presenceService;
        public PresenceController(IPresenceService presenceService)
        {
            _presenceService = presenceService;
        }

        // GET: api/<PresenceController>
        [HttpGet]
        public ActionResult<Presence> Get()
        {
            return Ok(_presenceService.GetAllPresences());
        }

        // GET api/<PresenceController>/5
        [HttpGet("{id,id,id}")]
        public ActionResult<Presence>Get(int idT, int idL, int idS)
        {
            var pre = _presenceService.GetPresenceById(idT, idL, idS);
            return pre;
        }

        // POST api/<PresenceController>
        [HttpPost]
        public void Post([FromBody] Presence p)
        {
            _presenceService.AddPresence(p);

        }

        // PUT api/<PresenceController>/5
        [HttpPut("{id,id,id}")]
        public ActionResult Put(int idT, int idL, int idS, [FromBody] Presence p)
        {
            _presenceService.UpdatePresence(idT, idL, idS, p);
            return Ok();
        }

        // DELETE api/<PresenceController>/5

    }
}
