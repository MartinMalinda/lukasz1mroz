using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            Console.Write("Provide 5 integers: ");
            string integers = Console.ReadLine();
            var data = integers.Split(' ');
            int num1 = int.Parse(data[0]);
            int num2 = int.Parse(data[1]);
            int num3 = int.Parse(data[2]);
            int num4 = int.Parse(data[3]);
            int num5 = int.Parse(data[4]);
            int sum = num1 + num2 + num3 + num4 + num5;
            double avg = sum / 5.0;
            Console.WriteLine("Sum: " + sum + ", Average: " + avg);
        }
    }
}