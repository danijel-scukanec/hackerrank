using System;

namespace HackerRank.StringManipulation.CommonChild
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(commonChild("ABCD", "ABDC"));
            Console.WriteLine(commonChild("HARRY", "SALLY"));
            Console.WriteLine(commonChild("SHINCHAN", "NOHARAAA"));
            Console.WriteLine(commonChild("ABCDEF", "FBDAMN"));
        }

        public static int commonChild(string s1, string s2)
        {
            var array = LcsLength(s1, s2);
            return array[s1.Length, s2.Length];
        }

        static int[,] LcsLength(string a, string b)
        {
            int[,] C = new int[a.Length + 1, b.Length + 1]; // (a, b).Length + 1
            for (int i = 0; i < a.Length; i++)
                C[i, 0] = 0;
            for (int j = 0; j < b.Length; j++)
                C[0, j] = 0;
            for (int i = 1; i <= a.Length; i++)
                for (int j = 1; j <= b.Length; j++)
                {
                    if (a[i - 1] == b[j - 1])//i-1,j-1
                        C[i, j] = C[i - 1, j - 1] + 1;
                    else
                        C[i, j] = Math.Max(C[i, j - 1], C[i - 1, j]);
                }
            return C;
        }
    }
}
