using System;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {

            // Given base and n that are both 1 or more, compute recursively(no loops) the value of base 
            // to the n power, so powerN(3, 2) is 9(3 squared).

            Console.WriteLine(powerN(3, 5)); 
        }

        static int powerN(int baseN, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            else
            {
                return baseN * powerN(baseN, power - 1);

            }
        }
    }
}
