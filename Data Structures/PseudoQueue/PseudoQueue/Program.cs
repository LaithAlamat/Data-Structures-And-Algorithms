using System;
using System.Collections.Generic;

namespace PseudoQueue
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stack s = new Stack();
            s.push(3);
            s.push(3);
            s.push(3);

            Queue l = new Queue();
            l.enQueue(9);
            Console.WriteLine("Hello World!");
            l.enQueue(3);
            l.enQueue(3);
            l.enQueue(3);
            l.enQueue(4);
            l.enQueue(4);
            l.enQueue(9);
            l.deQueue();



            l.s1.print();




        }

        public class Node
        {
            public int data;
            public Node next;

        }

        public class Stack
        {
            public Node top;

            

            public Stack()
            {
                top = null;

            }
            public void push(int x)
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
            public int Pop()
            {
                try
                {
                    int peek = -1;
                    if (top != null)
                    {
                        peek = top.data;
                        top = top.next;
                    }
                    return peek;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Stack Empty");
                    return -1;

                }


            }
            public int Peek()
            {
                try
                {
                    if (top != null)
                    {
                        return top.data;
                    }
                    else
                    {
                        return -1;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine("Stack Empty");
                    return -1;

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

           
            public string print()
            {

                if (top == null)
                {
                    Console.WriteLine("Stack Underflow");
                    return "";
                }
                else
                {
                    Node temp = top;
                    string str = "";
                    while (temp != null)
                    {
                        Console.WriteLine("{0} ", temp.data);
                        str += temp.data + "";
                        temp = temp.next;
                    }
                    return str;
                }
            }
        }
        public class Queue
        {
            public Stack s1 = new Stack();
            public Stack s2 = new Stack();
            


            public void enQueue(int x)
            {
               
                while (s1.top != null)  //  s1 to s2
                {
                    s2.push(s1.Pop());
                }

                // Push item into s1
                s1.push(x);

                
                while (s2.top != null) // s2 to s1
                {
                    s1.push(s2.Pop());
                }
            }

            
            public int deQueue()
            {
                
                if (s1 == null)
                {
                    Console.WriteLine("Queue is Empty");
                }

                // Return top of s1
                int x = s1.Peek();
                s1.Pop();
                return x;
            }
        };
    }
}
