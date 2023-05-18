using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.DAL.Data.Models
{
    public class Player
    {
        public Guid PlayerId { get; set; }
        public bool? IsInjured { get; set; }
        public string? Name { get; set; }
        public Guid PositionId { get; set; }
        public int? SquadNumber { get; set; }
        public Guid TeamId { get; set; }

        public Position? Position { get; set; }
        public Team? Team { get; set; }

        public ICollection<PlayerStatistic>? PlayerStatistics { get; set; }
    }
}
