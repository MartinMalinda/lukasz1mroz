using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one

            Console.Write("Provide first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Provide second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else if (num1 < num2)
            {
                Console.WriteLine(num2);
            }
        }
    }
}