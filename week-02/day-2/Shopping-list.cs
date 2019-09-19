using System;
using System.Collections.Generic;


namespace dictionary
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string[] products = { "eggs", "milk", "fish", "apples", "bread", "chicken" };
            List<string> grocery = new List<string>(products);

            // Do we have milk, bananas in the list?
            if (grocery.Contains("milk"))
            {
                Console.WriteLine("We have milk on the list");
            }
            else if (grocery.Contains("bananas"))
            {
                Console.WriteLine("We have bananas on the list");
            }


        }
    }
}