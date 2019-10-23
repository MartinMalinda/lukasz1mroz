using System;

namespace GreatestCommonDivisor
{
    class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GCDRecursive(3, 2);
        }

        public int GCDRecursive(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            if (a > b)
                return GCDRecursive(a % b, b);
            else
                return GCDRecursive(a, b % a);
        }
    }
}
