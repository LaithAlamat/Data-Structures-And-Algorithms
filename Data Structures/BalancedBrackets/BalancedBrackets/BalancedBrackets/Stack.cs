using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    public class Stack
    {
        public Node top;


        public Stack()
        {
            top = null;

        }
        public void Push(string x)
        {

            Node temp = new Node();


            if (temp == null)
            {
                Console.Write("Heap Overflow");
                return;
            }


            temp.data = x;


            temp.next = top;


            top = temp;
        }
        public string Pop()
        {
            try
            {
                if (top != null)
                {
                    Node temp = new Node();
                    temp = top;
                    top = top.next;
                    return temp.data;
                }
                else
                {
                    return "";

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Stack Empty");
                return "";

            }


        }
        public string Peek()
        {
            try
            {
                if (top != null)
                {
                    return top.data;
                }
                else
                {
                    return "";
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Stack Empty");
                return "";

            }
        }
        public bool IsEmpty()
        {
            if (top == null)
            {
                return top == null;
            }
            else
            {
                return false;
            }
        }
        public int count()
        {
            int count = 0;
            if (top == null)
            {
                
                return 0;
            }
            else
            {
                Node temp = top;
                
                while (temp != null)
                {

                    count++;
                    temp = temp.next;
                }
                return count;
            }
        }
    }
    public class QNode
    {
        public int key;
        public QNode next;


        public QNode(int key)
        {
            this.key = key;
            this.next = null;
        }
    }
}
