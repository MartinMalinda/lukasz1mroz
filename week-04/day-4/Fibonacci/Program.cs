using System;

namespace Fibonacci
{
    class Program
    { 
        public static void Fibonacci(int input)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < input; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            Console.WriteLine(b);
        }

        static void Main(string[] args)
        {
            Fibonacci(5);

            //Write a function that computes a member of the fibonacci sequence by a given index
            //Create tests for multiple test cases.
        }
    }
}
