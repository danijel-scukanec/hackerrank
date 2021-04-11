using System;

namespace HackerRank.Arrays.LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new int[] { 1, 2, 3, 4, 5 };
            var d1 = 2;
            var result1 = rotLeft(a1, d1);
            Print(a1, d1, result1);
        }

        static void Print(int[] a, int d, int[] result)
        {
            Console.WriteLine($"Array {string.Join(',', a)} rotated left by {d} is {string.Join(',', result)}");
        }

        static int[] rotLeft(int[] a, int d)
        {
            if (a.Length == 1)
            {
                return a;
            }

            var rotatedArray = new int[a.Length];

            var shift = d % a.Length;
            for (var i = 0; i < a.Length; i++)
            {
                var newIndex = (a.Length + i - shift) % a.Length;
                rotatedArray[newIndex] = a[i];
            }

            return rotatedArray;
        }
    }
}
