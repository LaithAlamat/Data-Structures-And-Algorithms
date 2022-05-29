using System;
using Xunit;
using static QuickSort.Sort;
using static QuickSort.Program;


namespace TestQuickSort
{
    public class UnitTest1
    {
        [Fact]
        public void NormalTest()
        {
            int[] MyArray = { 1, 25, 50, 8, 10, 23 };
            int n = MyArray.Length;
            PrintArray(MyArray);
            int[] expected = { 1, 8, 10, 23, 25, 50 };
            QuickSortMethod(MyArray, 0, n - 1);
            Assert.Equal(expected, MyArray);
        }

        [Fact]
        public void DuplicateTest()
        {
            int[] MyArray = { 1, 25, 50, 8, 25, 25 };
            int n = MyArray.Length;
            PrintArray(MyArray);
            int[] expected = { 1, 8, 25, 25, 25, 50 };
            QuickSortMethod(MyArray, 0, n - 1);
            Assert.Equal(expected, MyArray);
        }

        [Fact]
        public void NegativeTest()
        {
            int[] MyArray = { -1, 25, 50, 8, 25, 25 };
            int n = MyArray.Length;
            PrintArray(MyArray);
            int[] expected = { -1, 8, 25, 25, 25, 50 };
            QuickSortMethod(MyArray, 0, n - 1);
            Assert.Equal(expected, MyArray);
        }

        [Fact]
        public void AllNegativeTest()
        {
            int[] MyArray = { -1, -25, -50, -8, -25, -25 };
            int n = MyArray.Length;
            PrintArray(MyArray);
            int[] expected = { -50, -25, -25, -25, -8, -1 };
            QuickSortMethod(MyArray, 0, n - 1);
            Assert.Equal(expected, MyArray);
        }
    }
}
