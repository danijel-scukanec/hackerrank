using System;
using System.Collections.Generic;

namespace HackerRank.DictionariesAndHashmaps.RansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            var magazine1 = new string[] { "give", "me", "one", "grand", "today", "night" };
            var note1 = new string[] { "give", "one", "grand", "today" };
            checkMagazine(magazine1, note1);

            var magazine2 = new string[] { "two", "times", "three", "is", "not", "four" };
            var note2 = new string[] { "two", "times", "two", "is", "four" };
            checkMagazine(magazine2, note2);
        }

        static void checkMagazine(string[] magazine, string[] note)
        {
            var hashtable = new Dictionary<string, int>();

            foreach (var word in magazine)
            {
                if (hashtable.ContainsKey(word))
                {
                    hashtable[word]++;
                }
                else
                {
                    hashtable.Add(word, 1);
                }
            }

            foreach (var word in note)
            {
                var wordExists = hashtable.TryGetValue(word, out int counter);

                if (!wordExists || counter == 0)
                {
                    Console.WriteLine("No");
                    return;
                }                

                hashtable[word]--;
            }

            Console.WriteLine("Yes");
        }
    }
}
