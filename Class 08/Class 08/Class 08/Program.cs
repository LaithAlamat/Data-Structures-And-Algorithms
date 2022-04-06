using System;

namespace Class_08
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList first = new LinkedList();
            LinkedList second = new LinkedList();
            LinkedList output = new LinkedList();
            first.Append(1);
            first.Append(3);
            first.Append(2);
            first.printList();
            second.Append(5);
            second.Append(9);
            second.Append(4);
            second.printList();
            output.LinkedListZip(first.head,second.head);
            output.printList();

        }
        public class Node
        {
            public int value;
            public Node next;
        };
        public class LinkedList
        {
            public Node head;

            public void Append(int newElement)
            {
                Node newNode = new Node();
                newNode.value = newElement;
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
                        Console.Write(temp.value + " ");
                        str += temp.value + " ";
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
            public Node LinkedListZip(Node head, Node head2)
            {
                Node list1 = head;
                Node list2 = head2;
                int length1 = 0;
                int length2 = 0;
                int largest;
                int count = 0;


                while (list1.next != null)
                {
                    length1++;
                    list1 = list1.next;
                }
                while (list2.next != null)
                {
                    length2++;
                    list2 = list2.next;
                }

                if (length1 > length2)
                {
                    largest = length1;
                }
                else
                {
                    largest = length2;
                }
                list1 = head;
                list2 = head2;
                while (count < largest+1)
                {
                    if (list1 != null)
                    {
                        Append(list1.value);
                        list1 = list1.next;
                        
                        
                    }
                    if (list2 != null)
                    {
                        Append(list2.value);
                        list2 = list2.next;
                    }
                    count++;
                }
                return head;
            }
        }
     }
}
