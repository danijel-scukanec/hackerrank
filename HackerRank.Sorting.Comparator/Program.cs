using System;
using System.Collections.Generic;

namespace HackerRank.Sorting.Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var checker = new Checker();

            var players1 = new Player[] {
                new Player { Name = "Smith", Score = 20 },
                new Player { Name = "Jones", Score = 15 },
                new Player { Name = "Jones", Score = 20 }
            };
            Array.Sort(players1, checker);
            Print(players1);

            var players2 = new Player[] {
                new Player { Name = "amy", Score = 100 },
                new Player { Name = "david", Score = 100 },
                new Player { Name = "heraldo", Score = 50 },
                new Player { Name = "aakansha", Score = 75 },
                new Player { Name = "aleksa", Score = 150 }
            };
            Array.Sort(players2, checker);
            Print(players2);
        }

        static void Print(Player[] players)
        {
            foreach (var player in players)
            {
                Console.WriteLine($"Player with score {player.Score} and name {player.Name}");
            }
        }
    }

    public class Player
    {
        public string Name { get; set; }

        public int Score { get; set; }
    }

    public class Checker : IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {
            if (x.Score > y.Score)
            {
                return -1;
            }
            else if (x.Score < y.Score)
            {
                return 1;
            }
            else
            {
                var stringCompare = String.Compare(x.Name, y.Name);
                return stringCompare;
            }
        }
    }
}
