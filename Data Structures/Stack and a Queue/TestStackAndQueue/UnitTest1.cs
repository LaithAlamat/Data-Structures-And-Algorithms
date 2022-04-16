using System;
using Xunit;
using Stack_and_a_Queue;
using System.Collections.Generic;
using System.Collections;



namespace TestStackAndQueue
{
    public class UnitTest1
    {
        [Fact]
        public void PushStack()
        {
            Stack test = new Stack();
            test.Push(4);
            test.Push(5);
            Assert.Equal(5, test.Peek());
        }
        [Fact]
        public void PopStack()
        {
            Stack test = new Stack();
            test.Push(4);
            test.Push(5);
            test.Pop();

            Assert.Equal(4, test.Peek());
        }
        [Fact]
        public void PopStackEmptyAndEmpty()
        {
            Stack test = new Stack();
            Stack test1 = new Stack();
            test.Push(4);
            test.Push(5);
            test.Pop();
            test.Pop();


            Assert.Equal(test1,test);
        }
        [Fact]
        public void PeekEmptyStack()  
        {
            Stack stack = new Stack();
            Exception e = Assert.Throws<System.InvalidOperationException>(() => stack.Peek());
            Assert.Equal("Stack empty.", e.Message);
        }

        [Fact]
        public void TestEnqueueQueue()  
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            Assert.Equal(5, queue.Peek());
        }
        [Fact]
        public void TestMultiEnqueue() 
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            queue.Enqueue(4);
            Assert.Equal(5, queue.Peek());
        }
        [Fact]
        public void TestDequeue()  
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            queue.Enqueue(4);
            queue.Dequeue();
            Assert.Equal(4, queue.Peek());
        }
        [Fact]
        public void TestPeek()         
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            Assert.Equal(5, queue.Peek());
        }
        [Fact]
        public void TestEmptyQueue()  
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            queue.Enqueue(8);
            queue.Enqueue(2);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            Exception e = Assert.Throws<System.InvalidOperationException>(() => queue.Peek());
            Assert.Equal("Queue empty.", e.Message);
        }

        [Fact]
        public void TestEmptyQueueCreation()  
        {
            Queue queue = new Queue();
            Assert.Empty(queue);
        }
        [Fact]
        public void PeekEmptyQueue() 
        {
            Queue queue = new Queue();
            Exception e = Assert.Throws<System.InvalidOperationException>(() => queue.Peek());
            Assert.Equal("Queue empty.", e.Message);
        }
        
    }
}
