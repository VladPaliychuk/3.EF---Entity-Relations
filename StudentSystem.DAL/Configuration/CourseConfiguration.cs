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
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.CourseId);

            builder.Property(c => c.Name)
                .HasMaxLength(80)
                .IsUnicode(true);

            builder.Property(c => c.Description)
                .IsRequired(false)
                .IsUnicode(true);

            builder.Property(c => c.StartDate);

            builder.Property(c => c.EndDate);

            builder.Property(c => c.Price);

            new CourseSeeder().Seed(builder);
        }
    }
}
