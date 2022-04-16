using System;
using Xunit;
using PseudoQueue;
using static PseudoQueue.Program;

namespace TestPseudoQueue
{
    public class UnitTest1
    {
        [Fact]
        public void EnQueueTest()
        {
            Queue test = new Queue();
            test.enQueue(5);
            test.enQueue(4);
            Assert.Equal(5, test.s1.Peek());
        }
        [Fact]
        public void DeQueueTest()
        {
            Queue test = new Queue();
            test.enQueue(5);
            test.enQueue(4);
            test.deQueue();
            Assert.Equal(4, test.s1.Peek());
        }
        [Fact]
        public void EmptyQueue()
        {
            Queue test = new Queue();

            Assert.Equal(null, test.s1.top);
        }
    }
}
