using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.DictionariesAndHashmaps.CountTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            //var array1 = new List<long> { 1, 4, 16, 64 };
            //var r1 = 4;
            //var result1 = countTriplets(array1, r1);
            //Console.WriteLine(result1);

            //var array2 = new List<long> { 1, 2, 2, 4 };
            //var r2 = 2;
            //var result2 = countTriplets(array2, r2);
            //Console.WriteLine(result2);

            //var array3 = new List<long> { 1, 3, 9, 9, 27, 81 };
            //var r3 = 3;
            //var result3 = countTriplets(array3, r3);
            //Console.WriteLine(result3);

            //var array4 = new List<long> { 1, 5, 5, 25, 125 };
            //var r4 = 5;
            //var result4 = countTriplets(array4, r4);
            //Console.WriteLine(result4);

            //var array5 = new List<long> { 1, 4, 16, 64, 1, 4, 16, 64 };
            //var r5 = 4;
            //var result5 = countTriplets(array5, r5);
            //Console.WriteLine(result5);

            var array6 = new List<long> { 1237,1237,1237,1237,1237 };
            var r6 = 1;
            var result6 = countTriplets(array6, r6);
            Console.WriteLine(result6);
        }

        static long countTriplets(List<long> arr, long r)
        {
            var array = arr.ToArray();
            if (array.Length < 3)
            {
                return 0;
            }    

            var allElements = new Dictionary<long, int>();
            var pairs = new Dictionary<(long, long), int>();

            var counter = 0;
            for (var i = 0; i < array.Length; i++)
            {
                var currentElement = array[i];

                //add to all elements
                if (!allElements.ContainsKey(currentElement))
                {
                    allElements.Add(currentElement, 1);
                }
                else
                {
                    allElements[currentElement]++;
                }

                if (currentElement % r != 0)
                {
                    continue;
                }

                //add pairs
                var expectedPreviousElement = currentElement / r;
                if (allElements.ContainsKey(expectedPreviousElement))
                {
                    if (!pairs.ContainsKey((expectedPreviousElement, currentElement)))
                    {
                        pairs.Add((expectedPreviousElement, currentElement), allElements[expectedPreviousElement] * allElements[currentElement]);
                    }
                    else
                    {
                        pairs[(expectedPreviousElement, currentElement)] = allElements[expectedPreviousElement] * allElements[currentElement];
                    }
                }

                //add triplets
                var previousPair = (expectedPreviousElement / r, expectedPreviousElement);
                if (pairs.ContainsKey(previousPair))
                {
                    counter+= pairs[previousPair];
                }
            }

            //todo: finish algorithm

            return counter;
        }
    }
}
