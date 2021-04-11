using System;

namespace HackerRank.WarmUpChallenges.CountingValleys
{
    class Program
    {
        public static int countingValleys(int steps, string path)
        {
            var height = 0;
            var numberOfValleys = 0;
            for (var i = 0; i < path.Length; i++)
            {
                if(path[i] == 'U')
                {
                    height++;
                }
                else
                {
                    height--;

                    if (height == -1)
                    {
                        numberOfValleys++;
                    }
                }
            }

            return numberOfValleys;
        }

        static void Print(string path, int result)
        {
            Console.WriteLine($"Path {path} has {result} valleys");
        }

        static void Main(string[] args)
        {
            var path1 = "DDUUUUDD";
            var result1 = countingValleys(path1.Length, path1);
            Print(path1, result1);

            var path2 = "UDDDUDUU";
            var result2 = countingValleys(path2.Length, path2);
            Print(path2, result2);

        }
    }
}
