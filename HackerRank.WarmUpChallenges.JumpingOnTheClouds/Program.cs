using System;

namespace HackerRank.WarmUpChallenges.JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new int[] { 0, 1, 0, 0, 0, 1, 0 };
            var result1 = jumpingOnClouds(c1);
            Print(c1, result1);
        }

        static int jumpingOnClouds(int[] c)
        {
            var minJumps = 0;
            for (var i = 0; i < c.Length - 1;)
            {
                if (i + 2 < c.Length && c[i + 2] == 0)
                {
                    i += 2;
                }
                else
                {
                    i++;
                }

                minJumps++;
            }
            return minJumps;
        }

        static void Print(int[] c, int result)
        {
            Console.WriteLine($"For array {string.Join(',', c)} result is {result}");
        }
    }
}
