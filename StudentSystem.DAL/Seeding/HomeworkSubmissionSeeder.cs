using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentSystem.DAL.Data.Models;
using StudentSystem.DAL.Interfaces;
using static StudentSystem.DAL.Data.Enums.ContentTypeEnum;

namespace StudentSystem.DAL.Seeding
{
    public class HomeworkSubmissionSeeder : ISeeder<HomeworkSubmission>
    {
        private static readonly List<HomeworkSubmission> h = new()
        {
            new HomeworkSubmission
            {
                HomeworkId = 1,
                Content = "Task",
                ContentType = ContentType.Pdf,
                SubmissionTime = DateTime.Now,
                CourseId = 1,
                StudentId = 1
            },

            new HomeworkSubmission
            {
                HomeworkId = 2,
                Content = "Task",
                ContentType = ContentType.Aplication,
                SubmissionTime = DateTime.Now,
                CourseId = 2,
                StudentId = 1
            }
        };

        public void Seed(EntityTypeBuilder<HomeworkSubmission> builder)
        {
            builder.HasData(h);
        }
    }

}
