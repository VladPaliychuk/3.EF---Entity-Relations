using Football.DAL.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Football.DAL.Configuration
{
    public class PlayerStatisticConfiguration : IEntityTypeConfiguration<PlayerStatistic>
    {
        public void Configure(EntityTypeBuilder<PlayerStatistic> builder)
        {
            builder.HasKey(ps => new { ps.GameId, ps.PlayerId });

            builder.HasOne(ps => ps.Game)
                   .WithMany(g => g.PlayerStatistics)
                   .HasForeignKey(ps => ps.GameId);

            builder.HasOne(ps => ps.Player)
                   .WithMany(p => p.PlayerStatistics)
                   .HasForeignKey(ps => ps.PlayerId);

            builder.Property(ps => ps.ScoredGoals);

            builder.Property(ps => ps.Assists);

            builder.Property(ps => ps.MinutesPlayed);
        }
    }
}
