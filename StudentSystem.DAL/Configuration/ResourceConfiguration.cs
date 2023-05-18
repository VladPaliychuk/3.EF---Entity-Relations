using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StudentSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using StudentSystem.DAL.Seeding;

namespace StudentSystem.DAL.Configuration
{
    public class ResourceConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.HasKey(r => r.ResourceId);

            builder.Property(r => r.Name)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(r => r.Url)
                .IsUnicode(true);

            builder.Property(r => r.ResourceType)
                .HasConversion<string>();

            builder.HasOne(r => r.Course)
                .WithMany(c => c.Resources)
                .HasForeignKey(r => r.CourseId);

            new ResourceSeeder().Seed(builder);
        }
    }
}
