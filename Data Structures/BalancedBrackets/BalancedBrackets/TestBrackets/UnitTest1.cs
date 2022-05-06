using System;
using Xunit;
using  static Balanced;

namespace TestBrackets
{
    public class UnitTest1
    {
        [Fact]
        public void TestMatching()
        {
            string bracket1 = "(";
            string bracket2 = ")";
           
            Assert.True(Matching(bracket1,bracket2));
        }

        [Fact]
        public void TestNotMatching()
        {
            string bracket3 = "[";
            string bracket4 = ")";
            
            Assert.False(Matching(bracket3, bracket4));
        }

        [Fact]
        public void TestBalanced()
        {
            string[] bracket3 = { "{", "(", ")", "}", "[", "]" };

            Assert.True(AreBracketsBalanced(bracket3));

        }

        [Fact]
        public void TestNotBalanced()
        {
            string[] bracket3 = { "{", "{", ")", "}", "[", "]" };

            Assert.False(AreBracketsBalanced(bracket3));

        }
    }
}
