﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Comparable
{
    class Program
    {
        static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...

            foreach (var item in dominoes)
            {
                WriteDomino(item);
            }

            dominoes.Sort();

            foreach (var item in dominoes)
            {
                WriteDomino(item);
            }
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
        public static void WriteDomino(Domino domino)
        {
            int[] values = domino.GetValues();
            Console.Write($"[{values[0]}, {values[1]}], ");
        }
    }
}
