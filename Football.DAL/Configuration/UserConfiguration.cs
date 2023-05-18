using Football.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Football.DAL.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserId);

            builder.Property(u => u.Username)
                .HasMaxLength(50);

            builder.Property(u => u.Password)
                .HasMaxLength(50);

            builder.Property(u => u.Email)
                .HasMaxLength(50);

            builder.Property(u => u.Name)
                .HasMaxLength(50);

            builder.Property(u => u.Balance);
        }
    }
}
