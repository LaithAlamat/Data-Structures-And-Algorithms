using HashTables;
using System;
using System.Collections.Generic;
using static HashTables.HashTable;

namespace CommonValues
{
    class Program
    {
        public static void Main(string[] args)
        {

        }

        public static List<string> Common(Tree tree1, Tree tree2)
        {
            if (tree1 == null || tree2 == null) { throw new Exception("The tree is empty"); }

            List<string> answer = new List<string>();

            HashTable table1 = new HashTable(50);
            HashTable table2 = new HashTable(50);


            List<string> tree1Values = tree1.BreadthFirst(tree1.Root);
            List<string> tree2Values = tree1.BreadthFirst(tree1.Root);

            foreach (var value in tree1Values)
            {
                int key = table1.HashFuncation(value);
                table1.Insert(key.ToString(), value); 
            }
            foreach (var value in tree2Values)
            {
                int key = table2.HashFuncation(value);
                table2.Insert(key.ToString(), value);
            }

            List<string> table1Keys = table1.GetKeys(table1);

            for (int i = 0; i < table1Keys.Count; i++)
            {
                if (table2.Contains(table1Keys[i]))
                {
                    answer.Add(table1Keys[i]);
                }
            }
            if (answer.Count>0)
            {
                return answer;
            }
            else
            {
                return null;
            }
        }
    }
}
