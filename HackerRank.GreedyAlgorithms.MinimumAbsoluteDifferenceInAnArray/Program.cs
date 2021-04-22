using System;

namespace HackerRank.GreedyAlgorithms.MinimumAbsoluteDifferenceInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(minimumAbsoluteDifference(new int[] { -2, 2, 4 }));
            Console.WriteLine(minimumAbsoluteDifference(new int[] { 3, -7, 0 }));
            Console.WriteLine(minimumAbsoluteDifference(new int[] { -59, -36, -13, 1, -53, -92, -2, -96, -54, 75 }));
            Console.WriteLine(minimumAbsoluteDifference(new int[] { 1, -3, 71, 68, 17 }));
        }

        static int minimumAbsoluteDifference(int[] arr)
        {
            Array.Sort(arr);

            var min = int.MaxValue;
            for (var i = 1; i < arr.Length; i++)
            {
                var difference = Math.Abs(arr[i - 1] - arr[i]);
                if (difference < min)
                {
                    min = difference;
                    if (min == 0)
                    {
                        break;
                    }
                }
            }

            return min;
        }
    }
}
