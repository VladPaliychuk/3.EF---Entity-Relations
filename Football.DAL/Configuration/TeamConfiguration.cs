using Football.DAL.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.DAL.Configuration
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(t => t.TeamId);

            builder.Property(t => t.Name);

            builder.Property(t => t.LogoUrl);

            builder.Property(t => t.Initials);

            builder.Property(t => t.Budget);

            builder.HasOne(t => t.PrimaryKitColor)
                .WithMany(c => c.PrimaryColorTeams)
                .HasForeignKey(t => t.PrimaryKitColorId);

            builder.HasOne(t => t.SecondaryKitColor)
                .WithMany(c => c.SecondaryColorTeams)
                .HasForeignKey(t => t.SecondaryKitColorId)
                .IsRequired(false); 

            builder.HasOne(t => t.Town)
                .WithMany(c => c.Teams)
                .HasForeignKey(t => t.TownId)
                .IsRequired(false);
        }
    }
}
