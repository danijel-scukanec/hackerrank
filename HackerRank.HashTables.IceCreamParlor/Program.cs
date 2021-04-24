using System;
using System.Collections.Generic;

namespace HackerRank.HashTables.IceCreamParlor
{
    class Program
    {
        static void Main(string[] args)
        {
            whatFlavors(new int[] { 2, 1, 3, 5, 6 }, 5);
            whatFlavors(new int[] { 1, 4, 5, 3, 2 }, 4);
            whatFlavors(new int[] { 2, 2, 4, 3 }, 4);
            whatFlavors(new int[] { 4,3,2,5,7 }, 8);
            whatFlavors(new int[] { 2, 7, 8, 5, 8, 3, 8 }, 16);
        }

        static void whatFlavors(int[] cost, int money)
        {
            var hashtable = new Dictionary<int, int>();
            for (var i = 0; i < cost.Length; i++)
            {
                if (hashtable.ContainsKey(money - cost[i]))
                {
                    var index = hashtable[money - cost[i]];
                    Console.WriteLine($"{index} {i + 1}");
                    break;
                }

                hashtable.Add(cost[i], i + 1);
            }          
        }
    }
}
