using DependencyInjection.Api.Entities;

namespace DependencyInjection.Api.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
    }
}
