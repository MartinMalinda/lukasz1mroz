using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public class Animal
    {
        public int Hunger { get; set; } = 50;
        public int Thirst { get; set; } = 50;

        public Animal ()
        {
        }

        public void Eat()
        {
            this.Hunger--;
            Console.WriteLine($"Hunger is now at {Hunger}");
        }
        public void Drink()
        {
            this.Thirst--;
            Console.WriteLine($"Thirst is now at {Thirst}");
        }
        public void Play()
        {
            this.Hunger++;
            this.Thirst++;
            Console.WriteLine($"Hunger is now at {Hunger}");
            Console.WriteLine($"Thirst is now at {Thirst}");
        }
    }
}
