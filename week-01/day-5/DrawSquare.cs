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
            // %%%%%%
            // %    %
            // %    %
            // %    %
            // %    %
            // %%%%%%
            //
            // The square should have as many lines as the number was

            // Draw square empty inside
            // Ask for a number of lines 
            // If first or last line print number of %
            // For other lines if not first or last columns print empty, else %

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
                        if (j != 0 && j != num - 1)
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