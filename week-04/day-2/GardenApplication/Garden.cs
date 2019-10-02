using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApplication
{
    class Garden
    {
        // Create list for plants
        List<Plant> plants = new List<Plant>();

        // Adding to plants 
        public void AddToGarden(Plant plant)
        {
            plants.Add(plant);
        }

        // Showing garden
        public void ShowGarden()
        {
            foreach (var plant in plants)
            {
                plant.Introduce();
            }
        }

        // Watering garden
        public void Watering(int amountOfWater)
        {
            Console.WriteLine();
            Console.WriteLine($"Watering with {amountOfWater}");

            foreach (var plant in plants)
            {
                if (plant.NeedWater == true)
                {
                    plant.WaterLevel += (amountOfWater / plants.Count);
                }
            }
        }        
    }
}
