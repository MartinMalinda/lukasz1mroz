using System;
using Xunit;
using Fibonacci;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            Assert.Equal(8, Program.Fibonacci(5));
        }
    }
}
