using Football.DAL.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Football.DAL.Configuration
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(g => g.GameId);

            builder.HasOne(g => g.HomeTeam)
                .WithMany(t => t.HomeTeamGames)
                .HasForeignKey(g => g.HomeTeamId)
                .IsRequired(false);

            builder.HasOne(g => g.AwayTeam)
                .WithMany(t => t.AwayTeamGames)
                .HasForeignKey(g => g.AwayTeamId)
                .IsRequired(false);

            builder.Property(g => g.HomeTeamGoals);

            builder.Property(g => g.AwayTeamGoals);

            builder.Property(g => g.DateTime);

            builder.Property(g => g.HomeTeamBetRate);

            builder.Property(g => g.AwayTeamBetRate);

            builder.Property(g => g.DrawBetRate);

            builder.Property(g => g.Result)
                .HasMaxLength(6);
        }
    }
}
