using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.DictionariesAndHashmaps.SherlockAndAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = "mom";
            var result1 = sherlockAndAnagrams(array1);
            Console.WriteLine($"For string {array1} result is {result1}");

            var array2 = "abba";
            var result2 = sherlockAndAnagrams(array2);
            Console.WriteLine($"For string {array2} result is {result2}");

            var array3 = "abcd";
            var result3 = sherlockAndAnagrams(array3);
            Console.WriteLine($"For string {array3} result is {result3}");
        }

        static int sherlockAndAnagrams(string s)
        {
            var hashtable = new Dictionary<string, int>();

            for (var i = 0; i < s.Length; i++)
            {
                for (var j = i; j < s.Length; j++)
                {
                    var substring = s.Substring(i, j + 1 - i);
                    var sortedSubstring = string.Concat(substring.OrderBy(c => c));

                    if (!hashtable.ContainsKey(sortedSubstring))
                    {
                        hashtable.Add(sortedSubstring, 1);
                    }
                    else
                    {
                        hashtable[sortedSubstring]++;
                    }
                }
            }

            var counter = 0;
            foreach (var element in hashtable)
            {
                var n = element.Value;
                counter += n * (n - 1) / 2;
            }

            return counter;
        }
    }
}
