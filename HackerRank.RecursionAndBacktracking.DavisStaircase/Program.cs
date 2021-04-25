using System;
using System.Collections.Generic;

namespace HackerRank.RecursionAndBacktracking.DavisStaircase
{
    class Program
    {
        private static Dictionary<int, int> hashtable = new Dictionary<int, int>();

        static void Main(string[] args)
        {
            Console.WriteLine(stepPerms(5));
            Console.WriteLine(stepPerms(7));
            Console.WriteLine(stepPerms(27));
        }

        static int stepPerms(int n)
        {
            Console.WriteLine($"Count for n={n}");

            if (n == 1)
            {
                return 1;
            }

            if (n == 2)
            {
                return 2;
            }

            if (n == 3)
            {
                return 4;
            }

            if (!hashtable.ContainsKey(n))
            {
                hashtable[n] = stepPerms(n - 1) + stepPerms(n - 2) + stepPerms(n - 3);
            }

            return hashtable[n];
        }
    }
}
