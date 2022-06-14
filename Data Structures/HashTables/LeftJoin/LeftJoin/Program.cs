using System;
using System.Collections.Generic;

namespace LeftJoin
{
    class Program
    {
        public static void Main(string[] args)
        {
            HashTable map1 = new HashTable(50);
            map1.Insert("diligent", "employed");
            map1.Insert("fond", "enamored");
            map1.Insert("guide", "usher");
            map1.Insert("outfit", "garb");
            map1.Insert("wrath", "anger");
            HashTable map2 = new HashTable(50);
            map2.Insert("diligent", "idle");
            map2.Insert("fond", "averse");
            map2.Insert("guide", "follow");
            map2.Insert("flow", "jam");
            map2.Insert("wrath", "delight");
            LeftJoin(map1, map2);
            List<string> keys = map1.GetKeys(map1);
            foreach (var item in keys)
            {
                Console.WriteLine(map1.GetValue(item));
            }
        }


        public static HashTable LeftJoin(HashTable map1, HashTable map2)
        {
            foreach (var key in map2.GetKeys(map2))
            {
                int hashIndex = map2.HashFuncation(key);
                if (!map1.Contains(key))
                {
                    Console.WriteLine("Key does not exist");
                }
                else
                {
                    object answer = map2.GetValue(key);
                    map1.Set(key, answer);
                }
            }
            return map1;
        }
    }
}
