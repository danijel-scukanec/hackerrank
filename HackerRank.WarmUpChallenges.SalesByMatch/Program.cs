using System;
using System.Collections.Generic;

namespace HackerRank.WarmUpChallenges.SalesByMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int sockMerchant(int n, int[] ar)
        {
            if (n <= 1)
            {
                return 0;
            }

            var hashtable = new Dictionary<int, int>();
            var counter = 0;

            for (var i = 0; i < n; i++)
            {
                if (hashtable.ContainsKey(ar[i]))
                {
                    hashtable[ar[i]]++;

                    if (hashtable[ar[i]] % 2 == 0)
                    {
                        counter++;
                    }
                }
                else
                {
                    hashtable.Add(ar[i], 1);
                }
            }

            return counter;
        }
    }
}
