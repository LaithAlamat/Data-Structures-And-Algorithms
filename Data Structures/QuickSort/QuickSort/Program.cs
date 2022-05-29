using System;
using static QuickSort.Sort;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = { -4, 1, 25, 50, 8, 10, 23 };
            int n = MyArray.Length;
            Console.Write("Original Array\n");
            PrintArray(MyArray);

            QuickSortMethod(MyArray, 0, n - 1);
            Console.Write("\nSorted Array\n");
            PrintArray(MyArray);
        }
        public static void PrintArray(int[] Array)
        {
            int n = Array.Length;
            for (int i = 0; i < n; i++)
                Console.Write(Array[i] + " ");
            Console.Write("\n");
        }
    }
}
