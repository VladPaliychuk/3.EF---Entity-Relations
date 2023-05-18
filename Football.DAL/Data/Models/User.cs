using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.DAL.Data.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public int Balance { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Username { get; set; }
        public ICollection<Bet>? Bets { get; set; }
    }
}
