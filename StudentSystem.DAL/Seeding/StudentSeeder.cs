using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentSystem.DAL.Data.Models;
using StudentSystem.DAL.Interfaces;

namespace StudentSystem.DAL.Seeding
{
    public class StudentSeeder : ISeeder<Student>
    {
        private static readonly List<Student> s = new()
        {
            new Student
            {
                StudentId = 1,
                Name = "Oleh",
                PhoneNumber = "+123456789",
                RegisteredOn = DateTime.Now,
                Birthday = DateTime.Now
            },

            new Student
            {
                StudentId = 2,
                Name = "Ivan",
                PhoneNumber = "+123456789",
                RegisteredOn = DateTime.Now,
                Birthday = DateTime.Now
            }
        };

        public void Seed(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(s);
        }
    }
}
