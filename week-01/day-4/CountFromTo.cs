using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            Console.WriteLine("Please provide the first number:");
            int number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please provide the second number:");
            int number2 = Int32.Parse(Console.ReadLine());

            if (number2 <= number1)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
            {
                for (int i = number1; i < number2; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}