using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`

            int[] arr = { 3, 4, 5, 6, 7 };
            Array.Reverse(arr);

            foreach (var item in arr)
            {
                Console.Write(item);
            }

            Console.ReadLine();
        }
    }
}