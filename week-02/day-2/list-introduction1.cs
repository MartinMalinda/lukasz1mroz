using System;
using System.Collections.Generic;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>();

            Console.WriteLine(names.Count);

            names.Add("William");

            if (names.Count > 0)
            {
                Console.WriteLine("List is not empty");
            }
            else
            {
                Console.WriteLine("List is empty");
            }

            names.AddRange(new List<string>() { "John", "Amanda" });

            Console.WriteLine(names.Count);

            Console.WriteLine(names[2]);

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(i+1 + "." + names[i]);
            }

            names.RemoveAt(1);
        }
    }
}