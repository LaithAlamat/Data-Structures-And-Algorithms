using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class12
{
   public class Queue
    {
        public Node front, rear;

        public Queue()
        {
            this.front = this.rear = null;
        }


        public void enqueue(object animal)
        {


            Node temp = new Node(animal);


            if (this.rear == null)
            {
                if (animal.Equals("dog")||animal.Equals("cat"))

                    this.front = this.rear = temp;
                Console.WriteLine("enter a cat or dog");

                return;
            }

            if (animal.Equals("dog"))
            {
                this.rear.next = temp;
                this.rear = temp;
                Console.WriteLine("dog is added");
            }else if(animal.Equals("cat"))
                {
                this.rear.next = temp;
                this.rear = temp;
                Console.WriteLine("cat is added");

            }
            else
            {
                Console.WriteLine("enter a cat or dog");
            }
        }

        public void dequeue()
        {

            if (this.front == null)
                return;


            Node temp = this.front;
            this.front = this.front.next;


            if (this.front == null)
                this.rear = null;
        }
       
        public bool isEmpty()
        {
            return this.front == null;
        }
    }
}

