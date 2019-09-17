using System;

namespace GreenFox
{
    class Program
    {

        static void SubInt (int num, int[] nums)
        {
            int[] containing = new int[5];

            for (int i = 0; i < nums.Length; i++)
            { 

                if (nums[i].ToString().Contains(num.ToString()))
                {                 
                    containing[i] = Array.IndexOf(nums, nums[i]);
                }
            }

            for (int i = 0; i < containing.Length; i++)
            {
                if (i == 0 || containing[i] > 0)
                {
                    Console.Write(containing[i] + " ");
                }              
            }
            Console.WriteLine();
           
        }

        static void Main(string[] args)
        {
            //  Create a function that takes a number and an array of integers as a parameter
            //  Returns the indices of the integers in the array of which the first number is a part of
            //  Or returns an empty array if the number is not part of any of the integers in the array

            //  Example:
            //  Console.WriteLine(SubInt(1, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: `[0, 1, 4]`
            //  Console.WriteLine(SubInt(9, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: '[]'

            SubInt(1, new int[] { 1, 11, 34, 52, 61 });

        }
    }
}