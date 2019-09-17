using System;

namespace Factorio
{
    class Program
    {

        static void Factorio(int number)
        {
            var fact = 1;
            for (int i = 1; i < number + 1; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }

        static void Main(string[] args)
        {
            // - Create a function called `Factorio`
            //   that returns it's input's factorial

            Factorio(4);
            Console.ReadLine();
        }
    }
}
