using System;
using System.Collections.Generic;

namespace HackerRank.Sorting.FraudulentActivityNotifications
{
    class Program
    {
        static void Main(string[] args)
        {
            var expenditures1 = new int[] { 10, 20, 30, 40, 50 };
            var d1 = 3;
            var result1 = activityNotifications(expenditures1, d1);
            Console.WriteLine(result1);

            var expenditures2 = new int[] { 2, 3, 4, 2, 3, 6, 8, 4, 5 };
            var d2 = 5;
            var result2 = activityNotifications(expenditures2, d2);
            Console.WriteLine(result2);

            var expenditures3 = new int[] { 1, 2, 3, 4, 4 };
            var d3 = 4;
            var result3 = activityNotifications(expenditures3, d3);
            Console.WriteLine(result3);

            var expenditures4 = new int[] { 0, 0, 0, 0, 0 };
            var d4 = 4;
            var result4 = activityNotifications(expenditures4, d4);
            Console.WriteLine(result4);

            var expenditures5 = new int[] { 1, 1, 1, 1, 1 };
            var d5 = 1;
            var result5 = activityNotifications(expenditures5, d5);
            Console.WriteLine(result5);
        }

        static int activityNotifications(int[] expenditure, int d)
        {
            var currentList = new List<int>();
            var notificationCounter = 0;

            for (var i = 0; i < d; i++)
            {
                currentList.Add(expenditure[i]);
            }
            var median = getMedian(currentList);

            for (var i = d; i < expenditure.Length; i++)
            {
                if (expenditure[i] >= median * 2)
                {
                    notificationCounter++;
                }

                currentList.RemoveAt(0);
                currentList.Add(expenditure[i]);
                median = getMedian(currentList);
            }

            return notificationCounter;
        }

        static double getMedian(List<int> currentList)
        {
            var array = currentList.ToArray();
            int[] sortedArray = new int[array.Length];

            // find smallest and largest value
            int minVal = array[0];
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal) minVal = array[i];
                else if (array[i] > maxVal) maxVal = array[i];
            }

            // init array of frequencies
            int[] counts = new int[maxVal - minVal + 1];

            // init the frequencies
            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i] - minVal]++;
            }

            // recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Sort the array
            for (int i = array.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[array[i] - minVal]--] = array[i];
            }

            if (sortedArray.Length % 2 == 0)
            {
                var middleIndex = sortedArray.Length / 2;
                return (sortedArray[middleIndex - 1] + sortedArray[middleIndex]) / (double)2;
            }
            else
            {
                var middleIndex = sortedArray.Length / 2;
                return sortedArray[middleIndex];
            }
        }     
        
        //todo: avoid sort because of time complexity
    }
}
