using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.DAL.Data.Models
{
    public class Position
    {
        public Guid PositionId { get; set; }
        public string? Name { get; set; }

        public ICollection<Player>? Players { get; set; }
    }
}
