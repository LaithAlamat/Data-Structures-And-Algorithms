using System;

namespace Stack_and_a_Queue
{
   public  class Program
    {
        static void Main(string[] args)
        {
            Stack obj = new Stack();
            //obj.push(11);
            //obj.push(22);
            //obj.push(33);
            //obj.push(44);

            //// print Stack elements
            //obj.print();

            // print Top element of Stack
            Console.Write("\nTop element is {0}\n", obj.Peek());

            // Delete top element of Stack
            obj.Pop();
            obj.Pop();
            obj.IsEmpty();
            // print Stack elements
            obj.print();

            // print Top element of Stack
            Console.WriteLine("\nTop element is {0}\n", obj.Peek());
            //    Queue q = new Queue();
            //    q.enqueue(10);
            //    q.enqueue(20);
            //    q.dequeue();
            //    q.dequeue();
            //    q.enqueue(30);
            //    q.enqueue(40);
            //    q.enqueue(50);
            //    q.dequeue();
            //    Console.WriteLine("Queue Front : " + q.front.key);
            //    Console.WriteLine("Queue Rear : " + q.rear.key);
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
                    if (top != null)
                    {
                        top = top.next;
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

                catch (Exception e) { 
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
        public class Queue
        {
           public  QNode front, rear;

            public Queue()
            {
                this.front = this.rear = null;
            }

            
            public void enqueue(int key)
            {

                
                QNode temp = new QNode(key);

                
                if (this.rear == null)
                {
                    this.front = this.rear = temp;
                    return;
                }

                
                this.rear.next = temp;
                this.rear = temp;
            }

            
            public void dequeue()
            {
               
                if (this.front == null)
                    return;

                
                QNode temp = this.front;
                this.front = this.front.next;

                
                if (this.front == null)
                    this.rear = null;
            }
            public int peek()
            {
                if (!isEmpty())
                {
                    return front.key;
                }
                else
                {
                    Console.WriteLine("Stack is empty");
                    return -1;
                }
            }
            public bool isEmpty()
            {
                return this.front == null;
            }
        }
    }
}
