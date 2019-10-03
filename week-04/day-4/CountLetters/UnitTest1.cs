using System;
using Xunit;
using CountLetters;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        string input = "pizza";
        Dictionary<string, int> pizzaCount = new Dictionary<string, int>
        {
            { "p", 1 },
            { "i", 1 },
            { "z", 2 },
            { "a", 1 }
        };

        [Fact]
        public void Test2()
        {
            Assert.Equal(pizzaCount, Program.StringChecker("pizza"));
        }
    }
}
