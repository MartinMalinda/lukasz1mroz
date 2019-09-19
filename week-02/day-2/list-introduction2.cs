using System;
using System.Collections.Generic;

namespace list2
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string[] fruits = { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };
            string[] newFruits = { "Passion Fruit", "Pomelo" };
            List<string> A = new List<string>(fruits);
            List<string> B = new List<string>(A);
            List<string> C = new List<string>(newFruits);

            if (A.Contains("Durian")) ;
            {
                Console.WriteLine("Durian is there");
            }

            B.Remove("Durian");

            A.Insert(4, "Kiwifruit");

            if (A.Count == B.Count)
            {
                Console.WriteLine("Lists are equal");
            }

            A.IndexOf("Avocado");

            B.AddRange(C);

            Console.WriteLine(A[3]);
        }
    }
}