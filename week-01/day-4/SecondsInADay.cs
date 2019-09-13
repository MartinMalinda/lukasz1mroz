using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;
            int totalCurrentSeconds = ((60 * 60 * 14) + (60 * 34) + 42);
            int totalSecondsMidnight = ((60 * 60 * 24));
            int remainingSeconds = totalSecondsMidnight - totalCurrentSeconds;
            Console.WriteLine(remainingSeconds);

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables

            Console.ReadLine();

        }
    }
}
