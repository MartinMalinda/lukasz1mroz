using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it

            Console.WriteLine("What's the distance in miles?");
            string userInput = Console.ReadLine();
            int result = Int32.Parse(userInput);
            Console.WriteLine(result * 1.6);

        }
    }
}
