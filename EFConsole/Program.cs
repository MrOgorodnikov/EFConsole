using EF2;
using System;
using System.Linq;

namespace EFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TeamContext db = new TeamContext())
            {
                var players = db.Players.ToList();                

                foreach (var p in players)
                {
                    Console.WriteLine(p.Name);
                    Console.WriteLine(p.Surname);
                    Console.WriteLine(p.TeamId);
                    Console.WriteLine(p.Team.Name);
                }

                Console.ReadKey();
            }
        }
    }
}
