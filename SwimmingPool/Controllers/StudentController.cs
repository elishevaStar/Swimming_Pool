using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using Swim.Core.Services;
using Swim.Service;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Swim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public ActionResult<Student> Get()
        {
            return Ok(_studentService.GetAllStudents());
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public ActionResult< Student> Get(int id)
        {
            var st=_studentService.GetStudentById(id);
            return st;
        }

        // POST api/<StudentController>
        [HttpPost]
        public ActionResult Post([FromBody] Student s)
        {
           _studentService.AddStudent(s);
            return Ok();

        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Student s)
        {
            _studentService.UpdateStudent(id, s);
            return Ok();
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _studentService.DeleteStudent(id);
            return Ok();
        }
    }
}
