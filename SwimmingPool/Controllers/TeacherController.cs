using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using Swim.Core.Services;
using Swim.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Swim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        // GET: api/<TeacherController>
        [HttpGet]
        public ActionResult<Teacher> Get()
        {
            return Ok(_teacherService.GetAllTeachers());
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public ActionResult<Teacher> Get(int id)
        {
            var teach= _teacherService.GetTeacherById(id);
            return teach;
        }

        // POST api/<TeacherController>
        [HttpPost]
        public ActionResult Post([FromBody] Teacher t)
        {
            _teacherService.AddTeacher(t);
            return Ok();

        }

        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Teacher t)
        {
            _teacherService.UpdateTeacher(id, t);   
            return Ok();
        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _teacherService.DeleteTeacher(id);
            return Ok();
        }
    }
}
