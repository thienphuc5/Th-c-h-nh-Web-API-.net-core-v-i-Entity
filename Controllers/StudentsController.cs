using _212.Data;
using _212.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace _212.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentContext _context;

        public StudentsController(StudentContext context)
        {
            _context = context;
        }

        //action
        [HttpPost("CreateStudent")]
        public async Task<IActionResult> CreateStudent(Student student)
        {

            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Student added successfully", student });

        }

    }
}
