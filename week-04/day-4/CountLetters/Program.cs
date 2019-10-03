using System;
using System.Collections.Generic;

namespace CountLetters
{
    public class Program
    {
        public static Dictionary<string, int> StringChecker(string input)
        {
            char[] letters = input.ToCharArray();
            Dictionary<string, int> letterOccurence = new Dictionary<string, int>();

            foreach (var item in letters)
            {
                string stringItem = item.ToString();
                int value;

                if (letterOccurence.ContainsKey(stringItem))
                {
                    if (letterOccurence.TryGetValue(stringItem, out value))
                    {
                        letterOccurence[stringItem] = value + 1;
                    }
                }
                else
                {
                    letterOccurence.Add(stringItem, 1);
                }
            }
            return letterOccurence;
        }
        static void Main(string[] args)
        {
        }
    }
}
