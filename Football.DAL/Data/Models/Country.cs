using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.DAL.Data.Models
{
    public class Country
    {
        public Guid CountryId { get; set; }
        public string? Name { get; set; }

        public ICollection<Town>? Towns { get; set; }
    }
}
