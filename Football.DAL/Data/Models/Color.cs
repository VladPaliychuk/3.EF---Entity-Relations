using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.DAL.Data.Models
{
    public class Color
    {
        public Guid ColorId { get; set; }
        public string? Name { get; set; }

        public ICollection<Team>? PrimaryColorTeams { get; set; }
        public ICollection<Team>? SecondaryColorTeams { get; set; }
    }
}
