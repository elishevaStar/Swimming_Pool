using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swim.API.Models;
using Swim.Core.DTOs;
using Swim.Core.Entities;
using Swim.Core.Services;
using Swim.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Swim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PresenceController : ControllerBase
    {
        private readonly IPresenceService _presenceService;
        private readonly IMapper _mapper;

        public PresenceController(IPresenceService presenceService, IMapper mapper)
        {
            _presenceService = presenceService;
            _mapper = mapper;
        }

        // GET: api/<PresenceController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var lst =await _presenceService.GetAllPresencesAsync();
            var lstDto = _mapper.Map<IEnumerable<PresenceDto>>(lst);
            return Ok(lstDto);
        }

        // GET api/<PresenceController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var presence =await _presenceService.GetPresenceByIdAsync(id);
            return Ok(_mapper.Map<PresenceDto>(presence));
        }

        // POST api/<PresenceController>
        [HttpPost]
        public async Task Post([FromBody] PresencePostModel p)
        {
            //var pres = new Presence
            //{
            //IsPresent = p.IsPresent,
            //StudentId = p.StudentId,
            //LessonId = p.LessonId
            //};
            var presence = new Presence();
            _mapper.Map(p, presence);
            await _presenceService.AddPresenceAsync(presence);

        }

        // PUT api/<PresenceController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] PresencePostModel p)
        {
            //var pres = new Presence
            //{
            //    IsPresent = p.IsPresent,
            //    StudentId = p.StudentId,
            //    LessonId = p.LessonId
            //};
            var existPresence = await _presenceService.GetPresenceByIdAsync(id);
            if (existPresence is null)
            {
                return NotFound();
            }
            _mapper.Map(p, existPresence);
            await _presenceService.UpdatePresenceAsync(id, existPresence);
            return Ok();
        }

        // DELETE api/<PresenceController>/5

    }
}
