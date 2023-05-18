using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Football.DAL.Data.Models;

namespace Football.DAL.Configuration
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasKey(c => c.ColorId);

            builder.Property(c => c.Name)
                .HasMaxLength(50);
        }
    }
}
