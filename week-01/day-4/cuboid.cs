
using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            int cubWidth = 3;
            int cubHeight = 3;
            int cubDepth = 3;
            int surface = (cubWidth * cubHeight) * 4 + (cubWidth * cubDepth) * 2;
            int volume = cubDepth * cubHeight * cubWidth;

            Console.Write("Surface Area: ");
            Console.WriteLine(surface);
            Console.Write("Volume: ");
            Console.WriteLine(volume);
        }
    }
}