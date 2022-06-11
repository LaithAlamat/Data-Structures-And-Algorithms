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
            Console.ReadLine();

        }


    }
}
