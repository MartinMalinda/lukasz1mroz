using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot
            Console.WriteLine("Give a number");
            int result = Int32.Parse(Console.ReadLine());

            if (result <= 0)
            {
                Console.WriteLine("Not enough");
            }
            else if (result == 1)
            {
                Console.WriteLine("One");
            }
            else if (result == 2)
            {
                Console.WriteLine("Two");
            }
            else
            {
                Console.WriteLine("A lot");
            }
        }
    }
}