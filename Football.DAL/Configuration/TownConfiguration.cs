using Football.DAL.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Football.DAL.Configuration
{
    public class TownConfiguration : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.HasKey(t => t.TownId);

            builder.Property(t => t.Name)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.HasOne(t => t.Country)
                   .WithMany(c => c.Towns)
                   .HasForeignKey(t => t.CountryId);
        }
    }
}
