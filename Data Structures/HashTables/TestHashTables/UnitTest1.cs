using HashTables;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestHashTables
{
    public class UnitTest1
    {
        [Fact]
        public void InsertTest()
        {
            HashTable hashTable = new HashTable(50);
            hashTable.Insert("ab", 5);
            Assert.Equal(5,hashTable.GetValue("ab"));
        }

        [Fact]
        public void GetValueTest()
        {
            HashTable hashTable = new HashTable(50);
            hashTable.Insert("ab", 5);
            object expected = hashTable.GetValue("ab");
            Assert.Equal(5, expected);
        }

        [Fact]
        public void NullTest()
        {
            HashTable hashTable = new HashTable(50);
            object expected = hashTable.GetValue("ab");
            Assert.Null(expected);
        }

        [Fact]
        public void KeysTest()
        {
            HashTable hashTable = new HashTable(50);
            hashTable.Insert("ab", 5);
            hashTable.Insert("bB", 6);
            hashTable.Insert("aB", 7);
            hashTable.Insert("Bc", 8);
            hashTable.Insert("cA", 9);
            hashTable.Insert("CC", 10);
            hashTable.Insert("Bb", 66);
            List<string> expected =hashTable.GetKeys(hashTable);
            List<string> list = new List<string>(new string[] {"ab", "Bc", "cA", "bB", "CC" });
            Assert.Equal(list,expected);
        }

        [Fact]
        public void BucketTest()
        {
            HashTable hashTable = new HashTable(50);
            hashTable.Insert("ab", 5);
            hashTable.Insert("bB", 6);
            hashTable.Insert("aB", 7);
            hashTable.Insert("Bc", 8);
            hashTable.Insert("cA", 9);
            hashTable.Insert("CC", 10);
            hashTable.Insert("Bb", 66);
            object expected = hashTable.GetValue("aB");

            Assert.Equal(7, expected);
        }
        [Fact]
        public void HashTest()
        {
            HashTable hashTable = new HashTable(50);
            hashTable.Insert("ab", 5);
            hashTable.Insert("bB", 6);
            hashTable.Insert("aB", 7);
            hashTable.Insert("Bc", 8);
            hashTable.Insert("cA", 9);
            hashTable.Insert("CC", 10);
            hashTable.Insert("Bb", 66);
            
            int Index = hashTable.HashFuncation("cc");
            bool istrue = Index < 50;
            Assert.True(istrue);
        }

    }
}
