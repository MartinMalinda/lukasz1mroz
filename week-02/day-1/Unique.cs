using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {

        static void Unique(int[] input)
        {
            int[] filtered = new int[5];


            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] != input[j])
                    {
                        filtered[i] = input[i];
                    }
                }
                Console.Write(filtered[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            //  Create a method that takes an array of integers as a parameter
            //  Returns an array of integers where every integer occurs only once

            //  Example

            Unique(new[] { 1, 11, 34, 11, 52, 61, 1, 34 });

            //  should print: `[1, 11, 34, 52, 61]`
        }
    }
}