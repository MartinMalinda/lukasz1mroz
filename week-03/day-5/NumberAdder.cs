﻿using System;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.

            Console.WriteLine(RecursiveAdder(3));
            Console.Read();
        }

        static int RecursiveAdder(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n + RecursiveAdder(n - 1);
            }
        }
    }
}