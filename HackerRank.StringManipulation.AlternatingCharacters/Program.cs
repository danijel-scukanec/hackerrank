using System;

namespace HackerRank.StringManipulation.AlternatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(alternatingCharacters("AABAAB"));
            Console.WriteLine(alternatingCharacters("AAAA"));
            Console.WriteLine(alternatingCharacters("BBBBB"));
            Console.WriteLine(alternatingCharacters("ABABABAB"));
            Console.WriteLine(alternatingCharacters("BABABA"));
            Console.WriteLine(alternatingCharacters("AAABBB"));
        }

        static int alternatingCharacters(string s)
        {
            var min = 0;
            for (var i = 1; i < s.Length; i++)
            {
                if(s[i] == s[i - 1])
                {
                    min++;
                }                
            }

            return min;
        }
    }
}
