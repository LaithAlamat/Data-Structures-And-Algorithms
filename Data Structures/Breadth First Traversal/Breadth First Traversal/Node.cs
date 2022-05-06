using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breadth_First_Traversal
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node Next { get; set; }
        public Node(int value)
        {
            Value = value;
            Left = Right = null;
        }
    }
}
