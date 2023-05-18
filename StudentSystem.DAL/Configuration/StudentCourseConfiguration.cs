using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudentSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystem.DAL.Seeding;

namespace StudentSystem.DAL.Configuration
{
    public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(sc => new { sc.StudentId, sc.CourseId });

            builder.HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCources)
                .HasForeignKey(s => s.StudentId);

            builder.HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCources)
                .HasForeignKey(sc => sc.CourseId);

            //new StudentCourseSeeder().Seed(builder);
        }
    }
}
