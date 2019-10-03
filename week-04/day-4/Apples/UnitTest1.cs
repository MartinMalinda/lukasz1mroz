using System;
using Xunit;
using Apples;

namespace ApplesXUnitTest
{
    public class UnitTest1
    {
        private Apple apple;
        public UnitTest1()
        {
            apple = new Apple();
        }

        [Fact]
        void Test1()
        {
            Assert.Equal("orange", apple.GetApple());
        }
    }
}
