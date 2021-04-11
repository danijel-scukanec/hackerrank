using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRank.WarmUpChallenges.SalesByMatch
{
    class Program
    {
        static void Main(string[] args)
        {           
            var ar1 = new int[] { 1, 2, 1, 2, 1, 3, 2 };
            var result1 = sockMerchant(ar1.Length, ar1);
            Print(ar1, result1);
        }

        static void Print(int[] ar, int result)
        {
            Console.WriteLine($"Result for array {string.Join(',', ar)} is {result}");
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
