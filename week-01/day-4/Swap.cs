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
            int a = 123;
            int b = 526;
            int tempC = 123;
            a = b;
            b = tempC;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadLine();

        }
	}
}