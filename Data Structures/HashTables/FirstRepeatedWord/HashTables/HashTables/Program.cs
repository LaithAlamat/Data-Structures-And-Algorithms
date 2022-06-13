using System;
using System.Collections.Generic;

namespace HashTables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashTable hashTable = new HashTable(50);
            hashTable.Insert("ab", 5);
            hashTable.Insert("bB", 6);
            hashTable.Insert("aB", 7);
            hashTable.Insert("Bc", 8);
            hashTable.Insert("cA", 9);
            hashTable.Insert("CC", 10);
            hashTable.Insert("Bb", 66);


            hashTable.GetKeys(hashTable);
            string input = "invite some people to some events";
            FirstRepeatedWordInAString(input);
        }

        public static string FirstRepeatedWordInAString(string input)
        {
            HashTable tabel = new HashTable(50);
            string[] splitted = input.Split(" ");

            for (int i = 0; i <= splitted.Length - 1; i++)
            {
                string c = splitted[i];
                if (tabel.Contains(c))
                {
                    Console.WriteLine(c);
                    return c;
                }

                else 
                {
                    tabel.Insert(c,splitted[i]);
                }
            }
            return null;
        }
    }
}
