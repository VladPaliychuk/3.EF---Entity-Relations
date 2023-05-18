using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.DAL.Data.Models
{
    public class Game
    {
        public Guid GameId { get; set; }
        public int? AwayTeamBetRate { get; set; }
        public int? AwayTeamGoals { get; set; }
        public Guid AwayTeamId { get; set; }
        public Team? AwayTeam { get; set; }
        public int? DrawBetRate { get; set; }
        public int? HomeTeamBetRate { get; set; }
        public int? HomeTeamGoals { get; set; }
        public Guid HomeTeamId { get; set; }
        public Team? HomeTeam { get; set; }
        public string? Result { get; set; }
        public DateTime? DateTime { get; set; }
        
        public ICollection<Bet>? Bets { get; set; }
        public ICollection<PlayerStatistic>? PlayerStatistics { get; set; }
    }
}
