using System;
using System.Collections.Generic;

namespace HackerRank.Search.Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(pairs(1, new List<int> { 1, 2, 3, 4 }));
            Console.WriteLine(pairs(2, new List<int> { 1, 5, 3, 4, 2 }));
        }

        public static int pairs(int k, List<int> arr)
        {
            var array = arr.ToArray();
            var hashtable = new Dictionary<int, int>();
            var numberOfPairs = 0;
            for (var i = 0; i < array.Length; i++)
            {
                var numberToSearch1 = array[i] - k;
                if(hashtable.ContainsKey(numberToSearch1))
                {
                    numberOfPairs++;
                }

                var numberToSearch2 = array[i] + k;
                if (hashtable.ContainsKey(numberToSearch2))
                {
                    numberOfPairs++;
                }
                

                hashtable.Add(array[i], 0);
            }

            return numberOfPairs;
        }
    }
}
