﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public int Value { get; set; }

        public Node Left;
        public Node Right;

        public Node(int value)
        {
            Value = value;
            Left = Right = null;
        }

    }
}
