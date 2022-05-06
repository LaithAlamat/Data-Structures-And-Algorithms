using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breadth_First_Traversal
{

    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            Front = Rear = node;
        }
        public void Enqueue(Node node)
        {
            if (Front == null)
            {
                Front = node;
            }
            Rear.Next = node;
            Rear = node;
        }


        public Node Dequeue()
        {
            if (Front != null)
            {
                Node temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp;
            }
            else throw new Exception("Queue is empty!");
        }

        public Node Peek()  
        {
            return Front;
        }

    }
}

