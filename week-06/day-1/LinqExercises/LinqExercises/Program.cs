using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            int[] ex4Array = new[] { 3, 9, 2, 8, 6, 5 };
            int[] ex5Array = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            string sample = "Guadalajara";

            // Exercise #1
            var allResultM = nums.Select(n => n);
            var allResultQ = from number in nums select number;

            // Exercise #2
            var averageResultM = nums.Where(n => n % 2 == 0).Average();
            var averageResultQ = (from num in nums where num % 2 == 0 select num).Average();

            // Exercise #3
            var squareResultM = nums.Where(n => n > 0).Select(n => n * n);
            var squareResultQ = from num in nums where num > 0 select num * num;

            // Exercise #4
            var square20M = ex4Array.Where(n => n * n > 20);
            var square20Q = from num in ex4Array where num * num > 20 select num;

            // Exercise #5
            var frequencyM = ex5Array.GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());
            var frequencyQ = from num in ex5Array group num by num into newNum select newNum.ToList();

            // Exercise #6
            var charFrequencyM = sample.ToArray().GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());
            var charFrequencyQ = from letter in sample.ToArray() group letter by letter into newLetter select newLetter.ToList();
        }
    }
}

