using System;

namespace SumElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `r`
            //   with the following content: `[54, 23, 66, 12]`
            // - Print the sum of the second and the third element

            int[] nums = {54, 23, 66, 12};
            int sum = 0;

            foreach (int num in nums)
            {
                sum += num;
            }
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}