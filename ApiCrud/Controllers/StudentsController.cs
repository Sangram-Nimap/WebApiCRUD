using ApiCrud.Data;
using ApiCrud.Dtos;
using ApiCrud.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbConnection _context;

        public StudentsController(AppDbConnection context)
        {
            this._context = context;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var students = await _context.students.ToListAsync();
            return Ok(students);
        }

        [HttpPost]
        public async Task<IActionResult> AddStudents(StudentDto studentDto)
        {
            var students = new Student()
            {
                Name = studentDto.Name,
                Email = studentDto.Email,
                LastName = studentDto.LastName,
                Address = studentDto.Address,

            };
            await _context.students.AddAsync(students);
            _context.SaveChanges();
            return Ok(students);


        }


        [HttpDelete]
        public async Task<IActionResult> DeleteStudent(int id )
        {
            var student = await _context.students.FindAsync(id);
            if (student is null)
            {
                return NotFound(id);
            }
            _context.students.Remove(student);
            _context.SaveChanges();
            return Ok(student);


        }
       

    }
}
