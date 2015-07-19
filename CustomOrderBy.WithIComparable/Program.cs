using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomOrderBy.WithIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Players ** (Not Ordered)");
            Console.WriteLine();
            var players = new List<Player>
            {
                new Player{Nickname = "Ash",Score = 100},
                new Player{Nickname = "Bender",Score = 33},
                new Player{Nickname = "Tony",Score = 999},
                new Player{Nickname = "Cary",Score = 834},
                new Player{Nickname = "Dundie",Score = 666},
                new Player{Nickname = "Faker",Score = 255},
                new Player{Nickname = "Emy",Score = 750},
            };

            players.ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("** Players ** (Ordered Descending by Score)");
            Console.WriteLine();
            //Sort() use the method CompareTo that was implemented in the Player class
            players.Sort();
            players.ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
