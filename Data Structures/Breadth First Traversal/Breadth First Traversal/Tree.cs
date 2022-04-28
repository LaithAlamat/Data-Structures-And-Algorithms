using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breadth_First_Traversal
{
    public class Tree
    {
        public Node Root { get; set; }
        public Tree()
        {
            Root = null;
        }
        public Tree(Node root)
        {
            Root = root;
        }
    }
}
