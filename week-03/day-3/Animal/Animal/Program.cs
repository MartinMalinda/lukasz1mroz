using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal tiger = new Animal();
            tiger.Eat();
            tiger.Play();
            tiger.Drink();
            Console.Read();
        }
    }
}
