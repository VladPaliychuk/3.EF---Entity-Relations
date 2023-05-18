using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentSystem.DAL.Data.Models;
using StudentSystem.DAL.Interfaces;

namespace StudentSystem.DAL.Seeding
{
    public class CourseSeeder : ISeeder<Course>
    {
        private static readonly List<Course> c = new()
        {
            new Course
            {
                CourseId = 1,
                Name = "OOP",
                Description = "OOP description",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                Price = 1000
            },

            new Course
            {
                CourseId = 2,
                Name = "DB",
                Description = "DB Description",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                Price = 2000
            }
        };

        public void Seed(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(c);
        }
    }
}

