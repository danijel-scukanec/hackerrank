using System;

namespace HackerRank.Sorting.MarkAndToys
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices1 = new int[] { 1, 2, 3, 4 };
            var k1 = 7;
            var result1 = maximumToys(prices1, k1);
            Console.WriteLine(result1);

            var prices2 = new int[] { 1, 12, 5, 111, 200, 1000, 10 };
            var k2 = 50;
            var result2 = maximumToys(prices2, k2);
            Console.WriteLine(result2);
        }

        static int maximumToys(int[] prices, int k)
        {
            Array.Sort(prices);

            var amountSpent = 0;
            var counter = 0;
            foreach(var price in prices)
            {
                if(amountSpent + price <= k)
                {
                    amountSpent += price;
                    counter++;
                }
            }

            return counter;
        }
    }
}
