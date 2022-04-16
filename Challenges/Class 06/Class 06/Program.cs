using System;

namespace Class_06
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList NewList = new LinkedList();
            NewList.Append(5);
            NewList.Append(10);
            NewList.Append(15);
            NewList.Append(20);
            NewList.Append(25);
            NewList.AddBefore(5, 7);
            NewList.AddAfter(10, 7);
            NewList.printList();
            NewList.SearchIndex(NewList.head,20);

        }

        public class Node
        {
            public int data;
            public Node next;
        };

        public class LinkedList
        {
           public Node head;
           

            public LinkedList()
            {
                head = null;
                
            }

            
            public void Append(int newElement)
            {
                Node newNode = new Node();
                newNode.data = newElement;
                newNode.next = null;
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node temp = new Node();
                    temp = head;
                    while (temp.next != null)
                        temp = temp.next;
                    temp.next = newNode;
                }
            }
            public string printList()
            {
                Node temp = new Node();
                temp = this.head;
                string str = "";
                if (temp != null)
                {
                    Console.Write("The list contains: ");
                    while (temp != null)
                    {
                        Console.Write(temp.data + " ");
                        str += temp.data + " ";
                        temp = temp.next;
                    }
                    Console.WriteLine();
                    return str;
                }
                else
                {
                    Console.WriteLine("The list is empty.");
                    return "";
                }
            }
            public bool Search(Node head, int value)
            {
                Node current = head;
                while (current != null)
                {
                    if (current.data == value)
                    {
                        return true;
                    }
                    current = current.next;
                }
                return false;
            }
            public void AddBefore(int index, int newElement)
            {
                Node newNode = new Node();
                newNode.data = newElement;
                if (head == null)
                {
                    Append(newElement);
                }
                else
                {
                    Node temp = new Node();
                    temp = this.head;
                    if (index == temp.data)
                    {
                        newNode.next = head;
                        head = newNode;
                    }
                    else
                    {
                        if (Search(head, index))
                        {
                            while (temp.next.data != index)
                            {
                                temp = temp.next;
                            }
                            newNode.next = temp.next;
                            temp.next = newNode;
                        }
                        else
                        {
                            Console.WriteLine("Value does not exists in the list(cant add before: {0})", index);

                        }
                    }
                 }
            }
            public void AddAfter(int index, int newElement)
            {
                Node newNode = new Node();
                newNode.data = newElement;
                if (head == null)
                {
                    Append(newElement);
                }
                else
                {
                    Node temp = new Node();
                    temp = this.head;
                    if (Search(head, index))
                   { 
                    while (temp.data != index)
                    {
                        temp = temp.next;
                    }
                        newNode.next = temp.next;
                        temp.next = newNode;
                    }
                    else
                    {
                        Console.WriteLine("Value does not exists in the list (cant after before: {0})", index);
                    }
                }
            }
            public void SearchIndex(Node head, int value)
            {
                Node current = head;
                int length = 0;
                int index = 0;
                int answer;
                while (current != null)
                {
                    length++;
                    current = current.next;
                }
                current = head;
                while (current != null)
                {
                    if (current.data == value)
                    {
                        answer = length - index-1 ;
                        Console.WriteLine("The {0} is in index: [{1}]", value, answer);
                        return;
                    }
                    index++;
                    current = current.next;
                }
                Console.WriteLine("Value does not exists in the list");
            }

           
        }
     }
}
    


