using System;
using System.Collections.Generic;
using System.Text;

namespace AnagramProject
{
    public class Anagram
    {
        public bool AnagramTestMethod(string firstString, string secondString)
        {
            bool anagram = true;
            char[] firstStringArr = firstString.ToLower().ToCharArray();
            char[] secondStringArr = secondString.ToLower().ToCharArray();
            Array.Sort(firstStringArr);
            Array.Sort(secondStringArr);
            string sortedFirstString = new string(firstStringArr);
            string sortedSecondString = new string(secondStringArr);

            if (sortedFirstString == sortedSecondString) anagram = true;
            else anagram = false;

            return anagram;
        }
    }
}
