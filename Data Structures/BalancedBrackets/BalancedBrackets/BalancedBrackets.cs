using System;
using BalancedBrackets;


public class Balanced
{
	public static Boolean Matching(string character1,string character2)
	{
		string s = "(";
		string s1 = ")";
		string c = "{";
		string c1 = "}"; 
		string v = "[";
		string v1 = "]";

		if (character1 == s && character2 == s1)
			return true;
		else if (character1 == c && character2 == c1)
			return true;
		else if (character1 == v && character2 == v1)
			return true;
		else
			return false;
	}

	
	public static Boolean AreBracketsBalanced(string[] exp)
	{
		
		
		Stack st = new Stack();


		for (int i = 0; i < exp.Length; i++)
		{
			if (exp[i] == "(" || exp[i] == "{"
				|| exp[i] == "[")
				st.Push(exp[i]);

			
			if (exp[i] == "}" || exp[i] == ")"
				|| exp[i] == "]")
			{
				int count = st.count();
				if (count == 0)
				{
					return false;
				}
				else if (!Matching(st.Pop(),
										exp[i]))
				{
					return false;
				}
			}
		}

		int count1 = st.count();

		if (count1 == 0)
			return true; 
		else
		{
			
			return false;
		}
	}

	
	
}


