using System.Runtime.InteropServices.ComTypes;
using DependencyInjection.Api.Entities;

namespace DependencyInjection.Api.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> _students;

        public StudentRepository()
        {
            _students = new List<Student>
            {
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Popescu Ion",
                    PlaceOfBirth = "Iasi",
                    Grade = 8.7m
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Vasilescu Maria",
                    PlaceOfBirth = "Brasov",
                    Grade = 9.3m
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Ionescu Petru",
                    PlaceOfBirth = "Iasi",
                    Grade = 6.5m
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Pavelescu Ionut",
                    PlaceOfBirth = "Neamt",
                    Grade = 7
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Stefanescu Ana",
                    PlaceOfBirth = "Bucuresti",
                    Grade = 7.2m
                }
            };
        }
        public List<Student> GetAllStudents()
        {
            //return _students;
            return _students.Skip(1).Take(3).ToList();
            return _students.Where(s => s.PlaceOfBirth == "Iasi").ToList();
        }
    }
}
