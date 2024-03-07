using AutoMapper;
using MediaBrowser.Model.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
    public class LessonController : ControllerBase
    {
        private readonly ILessonService _lessonService;
        private readonly IMapper _mapper;
        public LessonController(ILessonService lessonService, IMapper mapper)
        {
            _lessonService = lessonService;
            _mapper = mapper;
        }
        // GET: api/<LessonController>
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> Get()
        {
            var lst= await _lessonService.GetAllLessonsAsync();
            var lstDto = _mapper.Map<IEnumerable<LessonDto>>(lst);
            return Ok(lstDto);
        }

        // GET api/<LessonController>/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult> Get(int id)
        {
            var less =await _lessonService.GetLessonByIdAsync(id);
            return Ok(_mapper.Map<LessonDto>(less));
        }

        // POST api/<LessonController>
        [HttpPost]
        public async Task Post([FromBody] LessonPostModel less)
        {
            //var lesson = new Lesson { LessonDescription = less.LessonDescription, LessonDate = less.LessonDate, TeacherId = less.TeacherId };
            var lesson = new Lesson();
            _mapper.Map(less, lesson);
            await _lessonService.AddLessonAsync(lesson);

        }

        // PUT api/<LessonController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] LessonPostModel less)
        {
            //var lesson = new Lesson { LessonDescription = less.LessonDescription, LessonDate = less.LessonDate, TeacherId = less.TeacherId };
            var existLesson = await _lessonService.GetLessonByIdAsync(id);
            if (existLesson is null)
            {
                return NotFound();
            }
            _mapper.Map(less, existLesson);
            await _lessonService.UpdateLessonAsync(id, existLesson);
            return Ok();
        }

        // DELETE api/<LessonController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _lessonService.DeleteLessonAsync(id);       
            return Ok();
        }
    }
}
