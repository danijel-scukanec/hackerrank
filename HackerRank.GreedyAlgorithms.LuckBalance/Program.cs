using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.GreedyAlgorithms.LuckBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[][] { new int[] { 5, 1 }, new int[] { 1, 1 }, new int[] { 4, 0 } };
            var k1 = 2;
            Console.WriteLine(luckBalance(k1, array1));

            var array2 = new int[][] { new int[] { 5, 1 }, new int[] { 2, 1 }, new int[] { 1, 1 }, new int[] { 8, 1 }, new int[] { 10, 0 }, new int[] { 5, 0 } };
            var k2 = 3;
            Console.WriteLine(luckBalance(k2, array2));
        }

        static int luckBalance(int k, int[][] contests)
        {
            var maxAmountOfLuck = 0;

            var importantContestsRating = new List<int>();
            for (var i = 0; i < contests.Length; i++)
            {
                if (contests[i][1] == 0)
                {
                    maxAmountOfLuck += contests[i][0];
                }
                else
                {
                    importantContestsRating.Add(contests[i][0]);
                }
            }

            importantContestsRating = importantContestsRating.OrderByDescending(x => x).ToList();
            for (var i = 0; i < importantContestsRating.Count; i++)
            {
                if (i < k)
                {
                    maxAmountOfLuck += importantContestsRating[i];
                }
                else
                {
                    maxAmountOfLuck -= importantContestsRating[i];
                }
            }

            return maxAmountOfLuck;
        }
    }
}
