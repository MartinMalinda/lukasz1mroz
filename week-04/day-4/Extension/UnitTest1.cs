using System;
using Xunit;
using System.Collections.Generic;
using Extensions;

namespace Extensions
{
    public class ExtensionTests
    {
        Extension extension = new Extension();

        [Fact]
        public void TestAdd_2and3is5()
        {
            Assert.Equal(10, extension.Add(7, 3));
        }

        [Fact]
        public void TestAdd_1and4is5()
        {
            Assert.Equal(6, extension.Add(2, 4));
        }

        [Fact]
        public void TestMaxOfThree_First()
        {
            Assert.Equal(9, extension.MaxOfThree(5, 9, 3));
        }

        [Fact]
        public void TestMaxOfThree_Fhird()
        {
            Assert.Equal(5, extension.MaxOfThree(3, 4, 5));
        }

        [Fact]
        public void TestMedian_Four()
        {
            Assert.Equal(5, extension.Median(new List<int>() { 7, 5, 3, 5 }));
        }

        [Fact]
        public void TestMedian_Five()
        {
            Assert.Equal(3, extension.Median(new List<int>() { 1, 2, 3, 4, 5 }));
        }

        [Fact]
        public void TestIsVowel_a()
        {
            Assert.True(extension.IsVowel('a'));
        }

        [Fact]
        public void TestIsVowel_u()
        {
            Assert.True(extension.IsVowel('u'));
        }

        [Fact]
        public void testTranslate_bemutatkozik()
        {
            Assert.Equal("bevemuvutavatkovozivik", extension.Translate("bemutatkozik"));
        }

        [Fact]
        public void testTranslate_kolbice()
        {
            Assert.Equal("lavagovopuvus", extension.Translate("lagopus"));
        }
    }
}