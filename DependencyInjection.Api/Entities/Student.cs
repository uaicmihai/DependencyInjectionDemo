namespace DependencyInjection.Api.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PlaceOfBirth { get; set; }
        public decimal Grade { get; set; }
    }
}
