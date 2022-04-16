using System;

namespace Linked_List_Implementation
{
    public class Program
    {
        public class Node
        {
            public int value { get; set; }
            public Node next { get; set; }
            public Node(int value)
            {
                this.value = value;
                this.next = null;
            }
        }

        public class LinkedList
        {
            public Node head;
            
            public void Insert(int value)
            {
                Node new_node = new Node(value);
                new_node.next = head;
                head = new_node;
            }

            public bool Search(Node head,int value)
            {
                Node current = head;
                while (current != null)
                {
                    if(current.value == value)
                    {
                        return true;
                    }
                        current = current.next;
                }
                    return false;
            }
            public string printList()
            {
                String str = "";
                if (this.head == null)
                {
                    Console.WriteLine("Please enter a valid head");
                }
                Node current = this.head;
                while (current != null)
                {
                    str += current.value + "-->";
                    current = current.next;
                }
                Console.WriteLine(str);
                return str;
            }

        }

        public static void Main(string[] args)
        {
            LinkedList NewList = new LinkedList();
            NewList.Insert(5);
            NewList.Insert(10);
            NewList.Insert(15);
            NewList.Insert(20);
            NewList.Insert(25);

            if (NewList.Search(NewList.head, 2))
            {
                Console.WriteLine("Found!");
            }
            else
            {
                Console.WriteLine("Not Found!");
            }



            NewList.printList();
        }
    }
}
