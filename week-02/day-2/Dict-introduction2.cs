using System;
using System.Collections.Generic;

namespace dictionary
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> books = new Dictionary<string, string>
            {
                {"978-1-60309-452-8", "A letter to Jo"},
                {"978-1-60309-459-7", "Lupus"},
                {"978-1-60309-444-3", "Red Panda and Moon Bear"},
                {"978-1-60309-461-0", "The Lab"},
            };

            foreach (KeyValuePair<string, string> kvp in books)
            {
                Console.WriteLine("{1} (ISBN: {0})", kvp.Key, kvp.Value);
            }

            books.Remove("978-1-60309-444-3");

            books.Remove("The Lab");

            books.Add("978-1-60309-450-4", "They Called Us Enemy");
            books.Add("978-1-60309-453-5", "Why Did We Trust Him?");

            if (books.TryGetValue("478-0-61159-424-8", out string result))
            {
                Console.WriteLine("There is associated value");
            }
            else
            {
                Console.WriteLine("There isn't any associated value");
            }
            Console.WriteLine(books["978-1-60309-453-5"]);
        }

    }
}