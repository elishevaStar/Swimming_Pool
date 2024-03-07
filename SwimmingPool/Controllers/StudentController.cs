using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swim.API.Models;
using Swim.Core.DTOs;
using Swim.Core.Entities;
using Swim.Core.Services;
using Swim.Service;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Swim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentController(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;   
        }

        // GET: api/<StudentController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var lst =await _studentService.GetAllStudentsAsync();
            var lstDto = _mapper.Map<IEnumerable<StudentDto>>(lst);
            return Ok(lstDto);
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var stu = await _studentService.GetStudentByIdAsync(id);
            return Ok(_mapper.Map<StudentDto>(stu));
        }

        // POST api/<StudentController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] StudentPostModel stu)
        {
            var student = new Student();
            _mapper.Map(stu, student);
            await _studentService.AddStudentAsync(student);
            return Ok();
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] StudentPostModel stu)
        {
            var existStudent = await _studentService.GetStudentByIdAsync(id);
            if (existStudent is null)
            {
                return NotFound();
            }
            _mapper.Map(stu, existStudent);
            await _studentService.UpdateStudentAsync(id, existStudent);
            return Ok();
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _studentService.DeleteStudentAsync(id);
            return Ok();
        }
    }
}
