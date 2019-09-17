using System;

using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output

            int height = 4;
            int width = 4;
            int[,] grid = new int[height, width];

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(1);
                    }
                    Console.Write(0);
                }
                Console.WriteLine();
            }
            
        }
    }
}