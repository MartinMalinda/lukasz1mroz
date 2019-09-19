using System;
using System.Collections.Generic;
using System.Linq;

namespace dictionary
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>
            {
                {"William A. Lathan", "405-709-1865"},
                {"John K. Miller", "402-247-8568"},
                {"Hortensia E. Foster", "606-481-6467"},
                {"Amanda D. Newland", "319-243-5613"},
                {"Brooke P. Askew", "307-687-2982"},
            };

            // What is John K. Miller's phone number?
            Console.WriteLine("John K. Miller's phone is: {0}", phoneBook["John K. Miller"]);
            Console.WriteLine();

            // Whose phone number is 307-687-2982?
            foreach (KeyValuePair<string, string> record in phoneBook)
            {
                if (record.Value == "307-687-2982")
                {
                    Console.WriteLine("Number 307-687-2982 belongs to {0}", record.Key);
                    Console.WriteLine();
                }
            }

            // Do we know Chris E. Myers' phone number?
            if (phoneBook.TryGetValue("Chris E. Myers", out string value))
            {
                Console.WriteLine("Chris is in the book");
            }
            else
            {
                Console.WriteLine("Chris E. Myers isn't in the book");
            }
            Console.WriteLine();


        }
    }
}