using System;
using Xunit;
using static RomanNumbers.Program;

namespace TestRomans
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("XV",ToRoman(15));
        }

        [Fact]
        public void TestMoreThanAhundred()
        {
            Assert.Equal("CL", ToRoman(150));
        }

        [Fact]
        public void TestMoreThanTwohundred()
        {
            Assert.Equal("CCL", ToRoman(250));
        }
        [Fact]
        public void TestMoreThanNinehundred()
        {
            Assert.Equal("CML", ToRoman(950));
        }
    }
}
