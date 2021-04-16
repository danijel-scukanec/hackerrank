using System;
using System.Collections.Generic;

namespace HackerRank.Arrays.MinimumSwaps2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new[] { 7, 1, 3, 2, 4, 5, 6 };
            var result1 = minimumSwaps(array1);
            Console.WriteLine(result1);

            //var array2 = new[] { 4, 3, 1, 2 };
            //var result2 = minimumSwaps(array2);
            //Console.WriteLine(result2);
        }

        static int minimumSwapsBad(int[] arr)
        {
            var minSwaps = 0;
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j] && arr[j] == i + 1)
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                        minSwaps++;
                    }
                }
            }

            return minSwaps;
        }

        static int minimumSwaps(int[] arr)
        {
            var hashTable = new Dictionary<int, int>();
            for (var i = 0; i < arr.Length; i++)
            {
                hashTable.Add(arr[i], i + 1);
            }

            Console.WriteLine($"Array: {string.Join(',', arr)}");
            Console.WriteLine($"HashTable: {string.Join(',', hashTable)}");

            var minSwaps = 0;
            for (var i = 1; i < arr.Length + 1; i++)
            {
                if (hashTable[i] != i)
                {
                    hashTable[arr[i - 1]] = hashTable[i];
                    arr[hashTable[i] - 1] = arr[i - 1];
                    minSwaps++;
                }

                Console.WriteLine($"Array: {string.Join(',', arr)}");
                Console.WriteLine($"HashTable: {string.Join(',', hashTable)}");
            }

            return minSwaps; //todo: understand optimal solution
        }
    }
}
