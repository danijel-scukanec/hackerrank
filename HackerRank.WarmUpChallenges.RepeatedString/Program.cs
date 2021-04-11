using System;

namespace HackerRank.WarmUpChallenges.RepeatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "abcac";
            var n1 = 10;
            var result1 = repeatedString(s1, n1);
            Print(s1, n1, result1);
        }

        static void Print(string s, long n, long result)
        {
            Console.WriteLine($"For string {s} and number {n} number of occurrences is {result}");
        }

        static long repeatedString(string s, long n)
        {
            var counterOfAs = 0;
            foreach (var character in s)
            {
                if (character == 'a')
                {
                    counterOfAs++;
                }
            }

            var occurences = (n / s.Length) * counterOfAs;

            var remaining = n % s.Length;
            for (var i = 0; i < remaining; i++)
            {
                if (s[i] == 'a')
                {
                    occurences++;
                }
            }

            return occurences;
        }
    }
}
