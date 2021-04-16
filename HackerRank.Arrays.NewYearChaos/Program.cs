using System;

namespace HackerRank.Arrays.NewYearChaos
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[] { 1, 2, 3, 5, 4, 6, 7, 8 };
            minimumBribes(array1);

            var array2 = new int[] { 4, 1, 2, 3 };
            minimumBribes(array2);

            var array3 = new int[] { 2, 1, 5, 3, 4 };
            minimumBribes(array3);

            var array4 = new int[] { 1, 2, 5, 3, 7, 8, 6, 4 };
            minimumBribes(array4);

            var array5 = new int[] { 2, 1, 5, 3, 4 };
            minimumBribes(array5);
        }

        static void minimumBribesBad(int[] q)
        {
            var minBribes = 0;
            for (var i = 0; i < q.Length - 1; i++)
            {
                var currentBribes = 0;
                for(var j = i + 1; j < q.Length; j++)
                {
                    if(q[i] > q[j])
                    {
                        currentBribes++;
                    }
                    if(currentBribes > 2)
                    {
                        Console.WriteLine("Too chaotic");
                        return;
                    }
                }

                minBribes += currentBribes;
            }

            Console.WriteLine(minBribes);
        }

        static void minimumBribes(int[] q)
        {
            //todo: optimal solution
        }
    }
}
