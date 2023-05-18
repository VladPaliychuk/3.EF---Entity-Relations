using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentSystem.DAL.Data.Models;
using StudentSystem.DAL.Interfaces;
using static StudentSystem.DAL.Data.Enums.ResourceTypeEnum;

namespace StudentSystem.DAL.Seeding
{
    public class ResourceSeeder : ISeeder<Resource>
    {
        private static readonly List<Resource> resources = new()
        {
            new Resource
            {
                ResourceId = 1,
                Name = ".NET Code First",
                Url = "www.video.com",
                ResourceType = ResourceType.Video,
                CourseId = 1
            },

            new Resource
            {
                ResourceId = 2,
                Name = "c# Framework relations",
                Url = "www.video.com",
                ResourceType = ResourceType.Video,
                CourseId = 2
            }
        };

        public void Seed(EntityTypeBuilder<Resource> builder)
        {
            builder.HasData(resources);
        }
    }
}
