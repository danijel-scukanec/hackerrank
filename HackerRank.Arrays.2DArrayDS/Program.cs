using System;

namespace HackerRank.Arrays._2DArrayDS
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[][]
            {
                new int[]{ -1,-1,0,-9,-2,-2 },
                new int[]{-2,-1,-6,-8,-2,-5 },
                new int[]{-1,-1,-1,-2,-3,-4 },
                new int[]{ -1,-9,-2,-4,-4,-5},
                new int[]{-7,-3,-3,-2,-9,-9 },
                new int[]{-1,-3,-1,-2,-4,-5}
            };
            var result = hourglassSum(array);
            Print(result);
        }

        static void Print(int result)
        {
            Console.WriteLine($"Result is {result}");
        }

        static int hourglassSum(int[][] arr)
        {
            var maxSum = int.MinValue;

            for (var i = 0; i < arr.Length; i++)
            {
                if (i + 2 == arr.Length)
                {
                    break;
                }

                for (var j = 0; j < arr.Length; j++)
                {
                    if (j + 2 == arr.Length)
                    {
                        break;
                    }

                    var currentSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + 
                        arr[i+1][j + 1] + 
                        arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }                
            }

            return maxSum;
        }
    }
}
