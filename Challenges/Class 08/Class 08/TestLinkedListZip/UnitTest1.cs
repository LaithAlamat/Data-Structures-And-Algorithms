using System;
using Xunit;
using Class_08;
using static Class_08.Program;

namespace TestLinkedListZip
{
    public class UnitTest1
    {
        [Fact]
        public void TestArr1Empty()
        {
            LinkedList first = new LinkedList();
            LinkedList second = new LinkedList();
            LinkedList ans = new LinkedList();
            second.Append(4);
            second.Append(5);
            second.Append(6);
            ans.LinkedListZip(first.head,second.head);
            string result = ans.printList();
            Assert.Equal("4 5 6 ", result);

        }
        [Fact]
        public void TestArr2Empty()
        {
            LinkedList first = new LinkedList();
            LinkedList second = new LinkedList();
            LinkedList ans = new LinkedList();
            first.Append(4);
            first.Append(5);
            first.Append(6);
            ans.LinkedListZip(first.head, second.head);
            string result = ans.printList();
            Assert.Equal("4 5 6 ", result);

        }
        [Fact]
        public void TestArr2Longer()
        {
            LinkedList first = new LinkedList();
            LinkedList second = new LinkedList();
            LinkedList ans = new LinkedList();
            first.Append(4);
            first.Append(5);
            first.Append(6);
            second.Append(1);
            second.Append(1);
            second.Append(1);
            second.Append(1);

            ans.LinkedListZip(first.head, second.head);
            string result = ans.printList();
            Assert.Equal("4 1 5 1 6 1 1 ", result);

        }
        [Fact]
        public void TestArr1Longer()
        {
            LinkedList first = new LinkedList();
            LinkedList second = new LinkedList();
            LinkedList ans = new LinkedList();
            first.Append(4);
            first.Append(5);
            first.Append(6);
            first.Append(7);
            second.Append(1);
            second.Append(1);
            second.Append(1);

            ans.LinkedListZip(first.head, second.head);
            string result = ans.printList();
            Assert.Equal("4 1 5 1 6 1 7 ", result);

        }
    }
}
