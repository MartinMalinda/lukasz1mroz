using System;

namespace Doubling
{
    class Program
    {

        static void Doubling(int num)
        {
            num *= 2;
            Console.WriteLine(num);
        }

        static void Main(string[] args)
        {
            // - Create an integer variable named `baseNum` and assign the value `123` to it
            // - Create a function called `Doubling` that doubles it's input parameter and returns with an integer
            // - Print the result of `Doubling(baseNum)`

            int test = 123;
            Doubling(test);
            Console.ReadLine();
        }
    }
}