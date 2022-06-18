using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonValues
{
    public class Node
    {
        public string Value { get; set; }

        public Node Left;
        public Node Right;

        public Node(string value)
        {
            Value = value;
            Left = Right = null;
        }
    }
}
