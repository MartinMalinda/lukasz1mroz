using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApplication
{
    abstract class Plant
    {
        public abstract double WaterLevel { get; set; }
        public bool NeedWater { get; set; }

        public Plant() { }

        public abstract void Introduce();
        public abstract void NeedsWater();
    }
}
