using System;
using System.Collections.Generic;

namespace HackerRank.DictionariesAndHashmaps.CountTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new List<long> { 1, 4, 16, 64 };
            var r1 = 4;
            var result1 = countTriplets(array1, r1);
            Console.WriteLine(result1);

            var array2 = new List<long> { 1, 2, 2, 4 };
            var r2 = 2;
            var result2 = countTriplets(array2, r2);
            Console.WriteLine(result2);

            var array3 = new List<long> { 1, 3, 9, 9, 27, 81 };
            var r3 = 3;
            var result3 = countTriplets(array3, r3);
            Console.WriteLine(result3);

            var array4 = new List<long> { 1, 5, 5, 25, 125 };
            var r4 = 5;
            var result4 = countTriplets(array4, r4);
            Console.WriteLine(result4);

            var array5 = new List<long> { 1, 4, 16, 64, 1, 4, 16, 64 };
            var r5 = 4;
            var result5 = countTriplets(array5, r5);
            Console.WriteLine(result5);

            var array6 = new List<long> { 1237, 1237, 1237, 1237, 1237 };
            var r6 = 1;
            var result6 = countTriplets(array6, r6);
            Console.WriteLine(result6);

            var array7 = new List<long> { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            var r7 = 1;
            var result7 = countTriplets(array7, r7);
            Console.WriteLine(result7);

            var array8 = new List<long> { 1, 2, 1, 2, 4 };
            var r8 = 2;
            var result8 = countTriplets(array8, r8);
            Console.WriteLine(result8);
        }

        static long countTriplets(List<long> arr, long r)
        {
            var array = arr.ToArray();
            var tripletCounter = 0;
            var ones = new Dictionary<long, int>();
            var twos = new Dictionary<(long,long), int>();

            for (var i = 0; i < array.Length; i++)
            {               
                if (!ones.ContainsKey(array[i]))
                {
                    ones.Add(array[i], 1);
                }
                else
                {
                    ones[array[i]]++;
                }

                if(ones.ContainsKey(array[i] / r))
                {
                    if (twos.ContainsKey((array[i] / r, array[i])))
                    {
                        twos[(array[i] / r, array[i])] += ones[array[i] / r];
                    }
                    else
                    {
                        twos.Add((array[i] / r, array[i]), ones[array[i] / r]);
                    }
                }

                if(twos.ContainsKey((array[i] / r / r, array[i] / r)))
                {
                    tripletCounter += twos[(array[i] / r / r, array[i] / r)];
                }
            }

            return tripletCounter;
        }
    }
}
