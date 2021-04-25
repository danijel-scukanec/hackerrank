using System;
using System.Linq;

namespace HackerRank.Search.TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(triplets(new[] { 3, 5, 7 }, new[] { 3, 6 }, new[] { 4, 6, 9 }));
            Console.WriteLine(triplets(new[] { 1, 3, 5 }, new[] { 2, 3 }, new[] { 1, 2, 3 }));
            Console.WriteLine(triplets(new[] { 1, 4, 5 }, new[] { 2, 3, 3 }, new[] { 1, 2, 3 }));
            Console.WriteLine(triplets(new[] { 1, 3, 5, 7 }, new[] { 5, 7, 9 }, new[] { 7, 9, 11, 13 }));
        }

        static long triplets(int[] a, int[] b, int[] c)
        {
            a = a.Distinct().ToArray();
            b = b.Distinct().ToArray();
            c = c.Distinct().ToArray();

            Array.Sort(a);
            Array.Sort(b);
            Array.Sort(c);

            long numberOfPairs = 0;

            for (var i = 0; i < b.Length; i++)
            {
                long aCounter = getNumberOfSmallerElements(a, b[i]);
                long cCounter = getNumberOfSmallerElements(c, b[i]);                

                numberOfPairs += (long)aCounter * cCounter;
            }

            return numberOfPairs;
        }

        static int getNumberOfSmallerElements(int[] array, int value)
        {
            var lowIndex = 0;
            var highIndex = array.Length - 1;

            var counter = 0;
            while (lowIndex <= highIndex)
            {
                var middleIndex = lowIndex + (highIndex - lowIndex) / 2;
                if (array[middleIndex] <= value)
                {
                    counter = middleIndex + 1;
                    lowIndex = middleIndex + 1;
                }
                else
                {
                    highIndex = middleIndex - 1;
                }
            }

            return counter;
        }
    }
}
