using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApplication
{
    class Flower : Plant
    {
        double waterLevel = 0;
        string FlowerColor { get; set; }
        public override double WaterLevel
        {
            get { return waterLevel; }
            set
            {
                waterLevel += (value * 0.75);
            }
        }
            
        public Flower(string color)
        {
            this.FlowerColor = color;
        }

        public override void Introduce() 
        {
            Console.Write($"The {FlowerColor} Flower ");
            NeedsWater();
        }

        public override void NeedsWater()
        {
            if (WaterLevel < 5)
            {
                NeedWater = true;
                Console.WriteLine("needs water");
            }
            else if(WaterLevel > 5)
            {
                NeedWater = false;
                Console.WriteLine("doesn't need water");
            }
        }
    }

    // If water level < 5 needs water
}
