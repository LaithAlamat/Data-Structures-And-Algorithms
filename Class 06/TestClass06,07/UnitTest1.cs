using System;
using Xunit;
using Class_06;
using static Class_06.Program;

namespace TestClass06_07
{
    public class UnitTest1
    {
        [Fact]
        public void AppendAtEnd()
        {
            LinkedList NewList = new LinkedList();
            NewList.Append(5);
            NewList.Append(10);
            NewList.Append(15);
            NewList.Append(20);
            NewList.Append(25);

            string result = NewList.printList();
            Assert.Equal("5 10 15 20 25 ", result);
        }
        [Fact]
        public void InsertBeforeMid()
        {
            LinkedList NewList = new LinkedList();
            NewList.Append(5);
            NewList.Append(10);
            NewList.Append(15);
            NewList.Append(20);
            NewList.Append(25);
            NewList.AddBefore(15, 3);

            string result = NewList.printList();
            Assert.Equal("5 10 3 15 20 25 ", result);
        }

        [Fact]
        public void InsertBeforeFirst()
        {
            LinkedList NewList = new LinkedList();
            NewList.Append(5);
            NewList.Append(10);
            NewList.Append(15);
            NewList.Append(20);
            NewList.Append(25);
            NewList.AddBefore(5, 3);

            string result = NewList.printList();
            Assert.Equal("3 5 10 15 20 25 ", result);
        }
        [Fact]
        public void InsertAfterMid()
        {
            LinkedList NewList = new LinkedList();
            NewList.Append(5);
            NewList.Append(10);
            NewList.Append(15);
            NewList.Append(20);
            NewList.Append(25);
            NewList.AddAfter(15, 3);

            string result = NewList.printList();
            Assert.Equal("5 10 15 3 20 25 ", result);
        }
        [Fact]
        public void InsertAfterLast()
        {
            LinkedList NewList = new LinkedList();
            NewList.Append(5);
            NewList.Append(10);
            NewList.Append(15);
            NewList.Append(20);
            NewList.Append(25);
            NewList.AddAfter(25, 3);

            string result = NewList.printList();
            Assert.Equal("5 10 15 20 25 3 ", result);
        }
    }
}
