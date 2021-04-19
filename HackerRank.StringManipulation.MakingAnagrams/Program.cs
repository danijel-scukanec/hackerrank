using System;
using System.Collections.Generic;

namespace HackerRank.StringManipulation.MakingAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = "cde";
            var b1 = "abc";
            var result1 = makeAnagram(a1, b1);
            Console.WriteLine(result1);
        }

        static int makeAnagram(string a, string b)
        {
            var stringHistogram = new Dictionary<char, int>();
            var stringHistogramA = new Dictionary<char, int>();
            var stringHistogramB = new Dictionary<char, int>();

            foreach (var character in a)
            {

                if (!stringHistogram.ContainsKey(character))
                {
                    stringHistogram.Add(character, 0);
                }              

                if (!stringHistogramA.ContainsKey(character))
                {
                    stringHistogramA.Add(character, 1);
                }
                else
                {
                    stringHistogramA[character]++;
                }
            }

            foreach (var character in b)
            {
                if (!stringHistogram.ContainsKey(character))
                {
                    stringHistogram.Add(character, 0);
                }

                if (!stringHistogramB.ContainsKey(character))
                {
                    stringHistogramB.Add(character, 1);
                }
                else
                {
                    stringHistogramB[character]++;
                }
            }

            var min = 0;
            foreach(var element in stringHistogram)
            {
                if (!stringHistogramA.ContainsKey(element.Key))
                {
                    min += stringHistogramB[element.Key];
                }
                else if (!stringHistogramB.ContainsKey(element.Key))
                {
                    min += stringHistogramA[element.Key];
                }
                else
                {
                    min += Math.Abs(stringHistogramA[element.Key] - stringHistogramB[element.Key]);
                }
            }

            return min;
        }
    }
}
