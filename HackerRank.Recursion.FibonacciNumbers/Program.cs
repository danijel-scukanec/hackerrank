using System;

namespace HackerRank.Recursion.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fibonacci(5));
            Console.WriteLine(fibonacci(3));
        }

        public static int fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }
}
