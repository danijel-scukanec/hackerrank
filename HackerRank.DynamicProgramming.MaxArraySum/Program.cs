using System;
using System.Collections.Generic;

namespace HackerRank.DynamicProgramming.MaxArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(maxSubsetSum(new[] { -2, 1, 3, -4, 5 }));
            Console.WriteLine(maxSubsetSum(new[] { 3, 7, 4, 6, 5 }));
            Console.WriteLine(maxSubsetSum(new[] { 2, 1, 5, 8, 4 }));
            Console.WriteLine(maxSubsetSum(new[] { 3, 5, -7, 8, 10 }));
            Console.WriteLine(maxSubsetSum(new[] { -6, -5, -4, -3, -2 }));
        }

        static int maxSubsetSum(int[] arr)
        {
            var hashtable = new Dictionary<int, int>();
            hashtable.Add(0, arr[0]);
            hashtable.Add(1, Math.Max(arr[0], arr[1]));

            for (var i = 2; i < arr.Length; i++)
            {
                var currentMax = Math.Max(arr[i], arr[i] + hashtable[i - 2]);
                currentMax = Math.Max(currentMax, hashtable[i - 1]);
                hashtable.Add(i, currentMax);
            }

            return Math.Max(0, hashtable[arr.Length - 1]);
        }
    }
}