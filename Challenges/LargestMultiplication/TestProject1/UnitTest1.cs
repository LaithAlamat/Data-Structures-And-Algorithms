using System;
using System.Collections.Generic;
using Xunit;
using static LargestMultiplication.Program;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var numbers = new List<int>() { 7, 3, 5, 2 };
            Assert.Equal(105,Largest(numbers));
        }
        [Fact]
        public void TestSameNumber()
        {
            var numbers = new List<int>() { 3, 3, 3, 3 };
            Assert.Equal(27, Largest(numbers));
        }
    }
}
