using DependencyInjection.Api.Entities;

namespace DependencyInjection.Api.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        decimal GetAverageGrade();
    }
}
