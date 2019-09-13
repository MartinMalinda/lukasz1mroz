using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.Write("Please provide a number ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j < num - i; j++)
                {
                    Console.Write(" ");
                }
 
                for (int k = 1; k <= 2*i-1; k++)
                {
                    Console.Write("*");
                }
    
                Console.WriteLine();

            }

        }
    }
