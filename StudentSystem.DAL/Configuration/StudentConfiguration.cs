using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentSystem.DAL.Data.Models;
using StudentSystem.DAL.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.DAL.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.StudentId);

            builder.Property(s => s.Name)
                .HasMaxLength(100)
                .IsUnicode(true);

            builder.Property(s => s.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsRequired(false);

            builder.Property(s => s.RegisteredOn);

            builder.Property(s => s.Birthday)
                .IsRequired(false);

            new StudentSeeder().Seed(builder);
        }
    }
}
