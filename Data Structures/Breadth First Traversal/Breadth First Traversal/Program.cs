﻿using System;
using System.Collections.Generic;

namespace Breadth_First_Traversal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Root = new Node(2);
            tree.Root.Left = new Node(7);
            tree.Root.Right = new Node(5);
            tree.Root.Left.Left = new Node(2);
            tree.Root.Left.Right = new Node(6);
            tree.Root.Right.Right = new Node(9);
            tree.Root.Left.Right.Left = new Node(5);
            tree.Root.Left.Right.Right = new Node(11);
            tree.Root.Right.Right.Left = new Node(4);


            BreadthFirst(tree.Root);
        }

        public static List<int> BreadthFirst(Node root)
        {
            List<int> values = new List<int>();
            Queue Breadth = new Queue(root);
            while (Breadth.Peek() != null)
            {
                var Front = Breadth.Dequeue();
                values.Add(Front.Value);
                Console.Write(Front.Value + " ");
                if (Front.Left != null)
                {
                    Breadth.Enqueue(Front.Left);
                }
                if (Front.Right != null)
                {
                    Breadth.Enqueue(Front.Right);
                }
            }
            return values;
        }
    }
}
