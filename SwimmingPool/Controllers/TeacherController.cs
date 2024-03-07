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
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        private readonly IMapper _mapper;


        public TeacherController(ITeacherService teacherService, IMapper mapper)
        {
            _teacherService = teacherService;
            _mapper = mapper;   
        }

        // GET: api/<TeacherController>
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> Get()
        { 
           var lst= await _teacherService.GetAllTeachersAsync();
           var lstDto = _mapper.Map<IEnumerable<TeacherDto>>(lst);
            return Ok(lstDto);
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult> Get(int id)
        {
            var teach= await _teacherService.GetTeacherByIdAsync(id);
            return Ok(_mapper.Map<TeacherDto>(teach));
        }

        // POST api/<TeacherController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] TeacherPostModel t)
        {
            var teacher = new Teacher();
            _mapper.Map(t, teacher);
            await _teacherService.AddTeacherAsync(teacher);
            return Ok();

        }

        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] TeacherPostModel t)
        {
            
            var existTeacher = await _teacherService.GetTeacherByIdAsync(id);
            if (existTeacher is null)
            {
                return NotFound();
            }
            _mapper.Map(t, existTeacher);
            await _teacherService.UpdateTeacherAsync(id, existTeacher);   
            return Ok();
        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _teacherService.DeleteTeacherAsync(id);
            return Ok();
        }
    }
}
