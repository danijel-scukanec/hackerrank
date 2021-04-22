using System;

namespace HackerRank.StringManipulation.SpecialStringAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(substrCount(8, "mnonopoo"));
            Console.WriteLine(substrCount(5, "asasd"));
            Console.WriteLine(substrCount(7, "abcbaba"));
            Console.WriteLine(substrCount(4, "aaaa"));
            Console.WriteLine(substrCount(1, "a"));
        }

        static long substrCount(int n, string s)
        {
            var numberOfSpecialStrings = 0;
            for (var i = 0; i < s.Length;)
            {
                var sequentialCounter = 1;
                var sequentialIndex = i + 1;
                while (sequentialIndex < n)
                {
                    if (s[i] == s[sequentialIndex])
                    {
                        sequentialCounter++;
                    }
                    else
                    {
                        break;
                    }

                    sequentialIndex++;
                }

                numberOfSpecialStrings += sequentialCounter * (sequentialCounter + 1) / 2;
                i += sequentialCounter;
            }

            for (var i = 1; i < n; i++)
            {
                var sequentialIndex = 1;
                while (i - sequentialIndex >= 0 && i + sequentialIndex < n)
                {
                    if (sequentialIndex > 1 && s[i - sequentialIndex] != s[i - sequentialIndex + 1])
                    {
                        break;
                    }

                    if (s[i] != s[i - sequentialIndex] && s[i - sequentialIndex] == s[i + sequentialIndex])
                    {
                        numberOfSpecialStrings++;
                    }
                    else
                    {
                        break;
                    }

                    sequentialIndex++;
                }
            }

            return numberOfSpecialStrings;
        }
    }
}
