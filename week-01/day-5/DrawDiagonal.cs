using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was

            // Take number of lines
            // For first and last line and column write %
            // For rest, write only if line's number = column's number

            Console.Write("Provide number: ");
            int num = int.Parse(Console.ReadLine());
            string line = new string('%', num);
            int i, j = 0;

            for (i = 0; i < num; i++)
            {
                if (i != 0 && i != num - 1)
                {
                    for (j = 0; j < num; j++)
                    {
                        if (j != 0 && j != num - 1 && j != i)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("%");
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}