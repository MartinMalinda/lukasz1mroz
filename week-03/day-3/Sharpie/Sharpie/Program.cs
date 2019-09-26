using System;

namespace Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie bob = new Sharpie("violet", 10);

            bob.Use();

            Console.Read();
        }
        
    }
}
