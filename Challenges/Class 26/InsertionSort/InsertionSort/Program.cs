using System;

namespace InsertionSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = {8,4,23,42,16,15 };
            InsertionSorting test = new InsertionSorting();
            test.InsertionSortFunction(array);
            printArray(array);
        }

        public static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
        }
    }
}
