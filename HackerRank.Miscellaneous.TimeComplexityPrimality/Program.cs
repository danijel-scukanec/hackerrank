using System;

namespace HackerRank.Miscellaneous.TimeComplexityPrimality
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(primalitySlow(12));
            Console.WriteLine(primalitySlow(5));
            Console.WriteLine(primalitySlow(7));

            Console.WriteLine(primalityFast(12));
            Console.WriteLine(primalityFast(5));
            Console.WriteLine(primalityFast(7));
        }

        static string primalitySlow(int n)
        {
            if(n <= 1)
            {
                return "Not prime";
            }

            if(n == 2)
            {
                return "Prime";
            }
           
            for(var i = 2; i < n; i++)
            {
                if(n % i == 0)
                {
                    return "Not prime";
                }
            }

            return "Prime";
        }

        static string primalityFast(int n)
        {
            if (n <= 1)
            {
                return "Not prime";
            }

            if (n == 2)
            {
                return "Prime";
            }

            var boundary = (int)Math.Floor(Math.Sqrt(n));

            for (var i = 2; i <= boundary; i++)
            {
                if (n % i == 0)
                {
                    return "Not prime";
                }
            }

            return "Prime";
        }
    }
}
