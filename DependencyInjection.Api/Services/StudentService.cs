using DependencyInjection.Api.Entities;
using DependencyInjection.Api.Repositories;

namespace DependencyInjection.Api.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        public decimal GetAverageGrade()
        {
            var students = _studentRepository.GetAllStudents();
            return students.Select(s => s.Grade).Average();
        }
    }
}
