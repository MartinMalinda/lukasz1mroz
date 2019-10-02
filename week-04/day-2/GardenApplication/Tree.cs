using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApplication
{
    class Tree : Plant
    {
        double waterLevel = 0;
        string TreeColor { get; set; }
        public override double WaterLevel
        {
            get { return waterLevel; }
            set
            {
                waterLevel += (value * 0.4);
            }
        }
        public Tree(string color)
        {
            this.TreeColor = color;
        }

        public override void Introduce()
        {
            Console.Write($"The {TreeColor} Tree ");
            NeedsWater();
        }

        public override void NeedsWater()
        {
            if (WaterLevel < 10)
            {
                NeedWater = true;
                Console.WriteLine("needs water");
            }
            else if (WaterLevel > 10)
            {
                NeedWater = false;
                Console.WriteLine("doesn't need water");
            }
        }
    }
}


