using System;
using static Balanced;

namespace BalancedBrackets
{
    class Program
    {
		public static void Main(String[] args)
		{
			string[] exp = { "{", "(", ")", "}", "[", "]" };

			
			if (AreBracketsBalanced(exp))
				Console.WriteLine("Balanced ");
			else
				Console.WriteLine("Not Balanced ");
		}
	}
}
