
using System;
using System.Collections.Generic;

namespace dictionary
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> testDict = new Dictionary<int, string>
            {
                {97, "a"},
                {98, "b"},
                {99, "c"},
                {65, "A"},
                {66, "B"},
                {67, "C"},

            };

            if (testDict.Count == 0)
            {
                Console.WriteLine("Dictionary is empty");
            }
            else
            {
                Console.WriteLine("Dictionary is not empty");
            }

            testDict.Add(0, "smile");
            Console.WriteLine();

            foreach (var key in testDict.Keys)
            {
                Console.Write(key + " ");
            }

            Console.WriteLine();

            foreach (var value in testDict.Values)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            testDict.Add(68, "test value");
            Console.WriteLine(testDict.Count);
            Console.WriteLine(testDict[99]);
            testDict.Remove(97);
            testDict.Clear();
        }
    }
}