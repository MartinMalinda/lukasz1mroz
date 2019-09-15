using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was

            Console.Write("Provide the number of lines (half of diamond: ");
            var num = int.Parse(Console.ReadLine());
            int i, j, k, l = 0;

            for (i = 0; i < num; i++)
            {
                for (j = 0; j < num - i; j++)
                {
                    Console.Write(" ");
                }
                
                for (k = 0; k < i * 2 + 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (i = 0; i <= num - 1; i++)
            {
                for (j = 0; j <= i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < 2*(num - 1 -i); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}