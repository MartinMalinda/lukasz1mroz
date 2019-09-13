using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 3;
            a += 10;
            // make it bigger by 10

            Console.WriteLine(a);

            int b = 100;
            b -= 7;
            // make it smaller by 7

            Console.WriteLine(b);

            int c = 44;
            c *= 2;
            // please double c's value

            Console.WriteLine(c);

            double d = 125.0;
            d /= (d * 5);
            // please divide by 5 d's value

            Console.WriteLine(d);

            int e = 8;
            e *= (e * e);
            // please cube of e's value

            Console.WriteLine(e);

            int f1 = 123;
            int f2 = 345;
            bool comp = false;
            Console.WriteLine(comp);
            // tell if f1 is bigger than f2 (print as a boolean)

            int g1 = 350;
            int g2 = 200;
            bool comp1 = false;
            Console.WriteLine(comp1);
            // tell if the double of g2 is bigger than g1 (print as a boolean)
            // Probably it's supposed to be solved with if(), but calculation was too easy :)

            var h = 1357988018575474;
            var i = (h % 11);
            if(i > 0)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
            // tell if 11 is a divisor of h (print as a boolean)

            int i1 = 10;
            int i2 = 3;

            if (i1 > i2 && i1 < i2 * i2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)

            int j = 1521;


            if (j % 3 == 0 && j % 5 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            
            // tell if j is divisible by 3 or 5 (print as a boolean)

            Console.ReadLine();

        }
    }
}