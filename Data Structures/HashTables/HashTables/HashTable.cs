using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public class HashTable
    {
        private Node[] universe;
        private readonly int tableSize;

        public HashTable(int maxTableSize)
        {
            tableSize = maxTableSize;
            universe = new Node[tableSize];
        }

        public int HashFuncation(string key)
        {
            int index = 7;
            int asciiVal = 0;
            for (int i = 0; i < key.Length; i++)
            {
                asciiVal = (int)key[i] * i;
                index = index * 31 + asciiVal;
            }
            return index % tableSize;
        }
        public void Insert(string key, object value)
        {
            int genIndex = HashFuncation(key);
            Node node = universe[genIndex];

            if (node == null)
            {
                universe[genIndex] = new Node() { Key = key, Value = value };
                return;
            }

            if (node.Key == key)
                throw new Exception("Can't use same key!");

            while (node.Next != null)
            {
                node = node.Next;
                if (node.Key == key)
                    throw new Exception("Can't use same key!");
            }

            Node newNode = new Node() { Key = key, Value = value, Previous = node, Next = null };
            node.Next = newNode;
        }
        public object GetValue(string key)
        {
            int genIndex = HashFuncation(key);
            Node node = universe[genIndex];
            while (node != null)
            {
                if (node.Key == key)
                {
                    return node.Value;
                }
                node = node.Next;
            }

            return null;
        }

        public List<string> GetKeys(HashTable input)
        {
            List<string> output = new List<string>();

            for (int i = 0; i < input.universe.Length - 1; i++)
            {
                if (input.universe[i] != null)
                {

                    output.Add(input.universe[i].Key);
                }
            }

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            return output;
        }

        public bool Contains(string key)
        {
            int genIndex = HashFuncation(key);
            Node node = universe[genIndex];
            while (node != null)
            {
                if (node.Key == key)
                {
                    return true;
                }
                node = node.Next;
            }

            return false; 
        }

        public void Set(string key, object value)
        {
            int genIndex = HashFuncation(key);
            Node node = universe[genIndex];


            if (node == null)
            {
                universe[genIndex] = new Node() { Key = key, Value = value };
                return;
            }

            if (node.Key == key)
                universe[genIndex].Value = value;

            

            Node newNode = new Node() { Key = key, Value = value, Previous = node, Next = null };
            node.Next = newNode;
        }


    }
}
