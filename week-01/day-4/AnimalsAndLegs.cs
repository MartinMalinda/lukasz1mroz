using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            Console.Write("How many chickens? ");
            int chickens = Int32.Parse(Console.ReadLine());
            Console.Write("How many pigs? ");
            int pigs = Int32.Parse(Console.ReadLine());
            int legsAll = chickens * 4 + pigs * 4;
            Console.WriteLine(legsAll);
        }
    }
}