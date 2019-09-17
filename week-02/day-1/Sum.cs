using System;

namespace Sum
{
    class Program
    {

        static void Sum(int num)
        {
            var sum = 0;
            for (int i = 1; i < num + 1; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        static void Main(string[] args)
        {
            // Write a function called `sum` that returns the sum of numbers from zero to the given parameter

            Sum(4);

        }
    }
}