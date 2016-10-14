using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2
{
    class Team
    {
        public int Id { get; set; }
        public string Coach { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public Team()
        {
            Players = new List<Player>();
        }
    }
}
