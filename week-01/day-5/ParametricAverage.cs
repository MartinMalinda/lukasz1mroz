using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            Console.Write("How many numbers to analyze?");
            double input = double.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < input; i++)
            {
                Console.Write("Provide number: ");
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine("Sum: {0} Average: {1}", sum, (sum / input));
        }
    }
}