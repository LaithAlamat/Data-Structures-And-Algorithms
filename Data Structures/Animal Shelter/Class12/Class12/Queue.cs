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


            public void enqueue(object key)
            {


                Node temp = new Node(key);


                if (this.rear == null)
                {
                    this.front = this.rear = temp;
                    return;
                }


                this.rear.next = temp;
                this.rear = temp;
            }


            public void dequeue(string animal)
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


