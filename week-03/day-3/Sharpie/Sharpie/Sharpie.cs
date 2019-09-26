using System;
using System.Collections.Generic;
using System.Text;

namespace Sharpie
{
    class Sharpie
    {
        public string Color { get; set; }
        public float Width { get; set; }
        public float InkAmount { get; set; } = 100;

        public Sharpie(string color, float width)
        {
            this.Color = color;
            this.Width = width;
        }

        public void Use()
        {
            InkAmount--;
            Console.WriteLine($"You used Sharpie, ink amount is now {InkAmount}");
        }

    }

}
