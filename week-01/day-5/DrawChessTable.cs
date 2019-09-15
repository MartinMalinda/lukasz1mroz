using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //
            // Store number of lines in var
            //

            string line1 = " % % % %";
            string line2 = "% % % % ";

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(line1);
                Console.WriteLine(line2);
            }
            Console.WriteLine();
            }
        }
        
    }