using InsertionSort;
using System;
using Xunit;
using static InsertionSort.InsertionSorting;

namespace TestInsertionSort
{
    public class UnitTest1
    {
        [Fact]
        public void NormalTest()
        {
            int[] array = { 8, 4, 23, 42, 16, 15 };
            int[] result = {4 ,8 ,15 ,16 ,23 ,42 };
            InsertionSorting test = new InsertionSorting();
            test.InsertionSortFunction(array);
            Assert.Equal(array, result);
        }

        [Fact]
        public void DuplicateTest()
        {
            int[] array = { 4, 4, 23, 42, 16, 15 };
            int[] result = { 4, 4, 15, 16, 23, 42 };
            InsertionSorting test = new InsertionSorting();
            test.InsertionSortFunction(array);
            Assert.Equal(array, result);
        }

        [Fact]
        public void NegativeTest()
        {
            int[] array = { 8, -4, 23, 42, 16, 15 };
            int[] result = { -4, 8, 15, 16, 23, 42 };
            InsertionSorting test = new InsertionSorting();
            test.InsertionSortFunction(array);
            Assert.Equal(array, result);
        }

        [Fact]
        public void AllNegativeTest()
        {
            int[] array = { -8, -4, -23, -42, -16, -15 };
            int[] result = { -42, -23, -16, -15, -8, -4 };
            InsertionSorting test = new InsertionSorting();
            test.InsertionSortFunction(array);
            Assert.Equal(array, result);
        }
    }
}
