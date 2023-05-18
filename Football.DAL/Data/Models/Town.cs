using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.DAL.Data.Models
{
    public class Town
    {
        public Guid TownId { get; set; }
        public Guid CountryId { get; set; }
        public string? Name { get; set; }

        public Country? Country { get; set; }
        
        public ICollection<Team>? Teams { get; set; }
    }
}
