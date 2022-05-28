using MergeSort;
using System;
using Xunit;
using static MergeSort.MergeSorting;

namespace MergeSortTest
{
    public class UnitTest1
    {
        [Fact]
        public void NormalTest()
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            MergeSorting test = new MergeSorting();
            int[] result = { 5, 6, 7, 11, 12, 13 };
            test.MergesortFunction(arr);
            Assert.Equal(result, arr);
           
        }

        [Fact]
        public void DuplicateTest()
        {
            int[] arr = { 12, 12, 13, 5, 6, 7 };
            MergeSorting test = new MergeSorting();
            int[] result = { 5, 6, 7, 12, 12, 13 };
            test.MergesortFunction(arr);
            Assert.Equal(result, arr);

        }

        [Fact]
        public void NegativeTest()
        {
            int[] arr = { 12, 12, 13, -5, 6, 7 };
            MergeSorting test = new MergeSorting();
            int[] result = { -5, 6, 7, 12, 12, 13 };
            test.MergesortFunction(arr);
            Assert.Equal(result, arr);

        }
        [Fact]
        public void AllNegativeTest()
        {
            int[] arr = { -12, -12, -13, -5, -6, -7 };
            MergeSorting test = new MergeSorting();
            int[] result = { -13,-12,-12,-7,-6,-5 };
            test.MergesortFunction(arr);
            Assert.Equal(result, arr);

        }
    }
}
