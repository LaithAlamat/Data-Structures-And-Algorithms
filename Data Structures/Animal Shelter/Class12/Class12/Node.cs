using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Animalshelter.Program;

namespace Class12
{
    public class Node
    {
        public object key;
        public Node next;


        public Node(object key)
        {
            this.key = key;
            this.next = null;
        }

    }
}
