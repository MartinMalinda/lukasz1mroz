using System;
using System.Text;

namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter\'s Law: It you expect, even when you take into account Hofstadter\'s Law.";
            string words = "always takes longer than ";

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            StringBuilder myString = new StringBuilder(quote);
            myString.Insert(21, words);

            Console.WriteLine(myString);

            
        }
    }
}