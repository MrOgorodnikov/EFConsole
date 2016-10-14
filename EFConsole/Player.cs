using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2
{
    class Player
    {
        public int Id { set;  get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }

    }
}
