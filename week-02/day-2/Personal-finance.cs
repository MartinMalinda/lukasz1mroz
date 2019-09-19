using System;
using System.Collections.Generic;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            // Total spend
            // Biggest expense
            // Smallest expense
            // Average expense

            int[] expenses = { 500, 1000, 1250, 175, 800, 120 };
            List<int> names = new List<int>(expenses);
            int sum = 0;
            int big = expenses[0];
            int small = expenses[0];

            // Total spend
            for (int i = 0; i < expenses.Length; i++)
            {
                sum += expenses[i];

                if (expenses[i] > big)
                {
                    big = expenses[i];
                }

                if (expenses[i] < small)
                {
                    small = expenses[i];
                }

            }
            Console.WriteLine("Total expense is: {0}", sum);

            // Biggest expense
            Console.WriteLine("Biggest expense is: {0}", big);

            // Smallest expense
            Console.WriteLine("Smallest expense is: {0}", small);

            // Average expense
            int average = sum / 6;
            Console.WriteLine("Average expense is: {0}", average);
        }
    }
}