using System;

namespace HackerRank.Sorting.BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[] { 6, 4, 1 };
            countSwaps(array1);
        }

        static void countSwaps(int[] a)
        {
            var numSwaps = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        var temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        numSwaps++;
                    }
                }
            }

            Console.WriteLine($"Array is sorted in {numSwaps} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[a.Length - 1]}");
        }
    }
}
