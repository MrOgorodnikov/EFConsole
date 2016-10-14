using EF2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TeamContext db = new TeamContext())
            {
                var players = db.Players.ToList();

                Team t = db.Teams.Find(1);
                t.Players.ToList();

                foreach (var p in players)
                {
                    p.Team = db.Teams.Find(p.TeamId);               
                    Console.WriteLine(p.Name);
                    Console.WriteLine(p.Surname);
                    Console.WriteLine(p.TeamId);
                    Console.WriteLine(p.Team.Name);
                }
            }
        }
    }
}
