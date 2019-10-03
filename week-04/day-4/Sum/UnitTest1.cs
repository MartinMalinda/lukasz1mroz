using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Sum;

namespace SumTest
{
    public class UnitTest1
    {
        private Summary myNumbers;
        List<int> integers = new List<int> { 4, 4, 2, 8, 5 };
        List<int> empty = new List<int> { };
        List<int> one = new List<int> { 4 };
        List<int?> intNull = new List<int?> { null }; 
        public UnitTest1()
        {
            myNumbers = new Summary();
        }

        [Fact]
        void Test1()
        {
            Assert.Equal(23, myNumbers.SumInts(integers));
        }
        [Fact]
        void Test2()
        {
            Assert.Equal(0, myNumbers.SumInts(empty));
        }
        [Fact]
        void Test3()
        {
            Assert.Equal(4, myNumbers.SumInts(one));
        }
        [Fact]
        public void TestNullList()
        {
            Assert.Equal(null, myNumbers.SumAll(intNull));
        }


    }
}
