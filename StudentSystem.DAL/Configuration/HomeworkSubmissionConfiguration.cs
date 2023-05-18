using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentSystem.DAL.Data.Models;
using StudentSystem.DAL.Seeding;

namespace StudentSystem.DAL.Configuration
{
    public class HomeworkSubmissionConfiguration : IEntityTypeConfiguration<HomeworkSubmission>
    {
        public void Configure(EntityTypeBuilder<HomeworkSubmission> builder)
        {
            builder.HasKey(hs => hs.HomeworkId);

            builder.Property(hs => hs.Content)
                .IsUnicode(false)
                .HasConversion<string>();

            builder.Property(hs => hs.ContentType);

            builder.Property(hs => hs.SubmissionTime);

            builder.HasOne(hs => hs.Student)
                .WithMany(s => s.HomeworkSubmissions)
                .HasForeignKey(hs => hs.StudentId);

            builder.HasOne(hs => hs.Course)
                .WithMany(c => c.HomeworkSubmissions)
                .HasForeignKey(hs => hs.CourseId);

            new HomeworkSubmissionSeeder().Seed(builder);
        }
    }
}
