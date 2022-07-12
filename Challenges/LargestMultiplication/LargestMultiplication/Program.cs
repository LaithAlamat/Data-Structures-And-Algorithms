using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestMultiplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 7, 3, 5, 2 };
            Console.WriteLine(Largest(numbers));
        }

        public static int Largest(List<int> nums)
        {
            
            var sorted = new List<int>(nums.OrderBy(num => num));

            int product = sorted[sorted.Count - 1] * sorted[sorted.Count - 2] * sorted[sorted.Count - 3];

            return product;
        }
    }
}
