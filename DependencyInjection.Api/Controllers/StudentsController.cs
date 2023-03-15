using DependencyInjection.Api.Entities;
using DependencyInjection.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public List<Student> Get()
        {
            return _studentService.GetAllStudents();
        }

        [HttpGet("average")]
        public decimal GetAverageGrade()
        {
            return _studentService.GetAverageGrade();
        }
    }
}
