using System;
using Xunit;
using AnagramProject;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private Anagram sampleAnagram;
        string firstString = "pizza";
        string secondString = "hamburger";

        public UnitTest1()
        {
            sampleAnagram = new Anagram();
        }

        [Fact]
        public void Test1()
        {
            Assert.False(sampleAnagram.AnagramTestMethod(firstString, secondString));
        }
    }
}
