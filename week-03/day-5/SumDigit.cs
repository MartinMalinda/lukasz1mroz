using System;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {

            //Given a non-negative integer n, return the sum of its digits recursively (without loops).

            Console.WriteLine(DigitAdder(126));
        }

        static int DigitAdder(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            else
            {
                // Mod % 10 return rightmost number
                // Divide by 10 removes rightmost digit

                return (n % 10 + DigitAdder(n / 10));

            }
        }
    }
}