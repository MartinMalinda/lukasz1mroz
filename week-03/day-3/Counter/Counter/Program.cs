using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter num = new Counter();
            Console.WriteLine(num.Integer);
            num.Integer = 2;
            Console.WriteLine(num.Integer);
            Console.Read();
        }
    }
}
