using System;

namespace GardenApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Water with 40
            // Show the garden again
            // Water with 70 if not enough water

            // Creating plants
            Plant yellowFlower = new Flower("yellow");
            Plant blueFlower = new Flower("blue");
            Plant orangeTree = new Tree("orange");
            Plant purpleTree = new Tree("purple");

            // Creating garden
            Garden garden = new Garden();

            // Adding plants
            garden.AddToGarden(yellowFlower);
            garden.AddToGarden(blueFlower);
            garden.AddToGarden(orangeTree);
            garden.AddToGarden(purpleTree);

            // Showing garden
            garden.ShowGarden();
            garden.Watering(40);
            Console.WriteLine();
            garden.ShowGarden();
            garden.Watering(70);
            Console.WriteLine();
            garden.ShowGarden();
        }
    }
}
