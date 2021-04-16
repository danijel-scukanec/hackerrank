using System;
using System.Collections.Generic;

namespace HackerRank.DictionariesAndHashmaps.TwoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(twoStrings("hello", "world"));
            Console.WriteLine(twoStrings("hi", "world"));
        }

        static string twoStrings(string s1, string s2)
        {
            var hashtable = new Dictionary<char, int>();
            foreach (var character in s1)
            {
                if (!hashtable.ContainsKey(character))
                {
                    hashtable.Add(character, 0);
                }
            }

            foreach (var character in s2)
            {
                if (hashtable.ContainsKey(character))
                {
                    return "YES";
                }
            }

            return "NO";
        }
    }
}
