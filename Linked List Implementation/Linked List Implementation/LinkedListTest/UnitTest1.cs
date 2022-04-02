using System;
using Xunit;
using Linked_List_Implementation;
using static Linked_List_Implementation.Program;


namespace LinkedListTest
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyInstantiation()
        {
            LinkedList list = new LinkedList();

            Assert.Equal(null, list.head);
        }
        [Fact]
        public void Insert()
        {
            LinkedList list = new LinkedList();
            list.Insert(8);

            Assert.Equal(8, list.head.value);
        }
        [Fact]
        public void Head()
        {
            LinkedList NewList = new LinkedList();
            NewList.Insert(5);
            NewList.Insert(10);
            NewList.Insert(15);
            NewList.Insert(20);
            NewList.Insert(25);

            Assert.Equal(25, NewList.head.value);

        }
        [Fact]
        public void search()
        {
            LinkedList NewList = new LinkedList();
            NewList.Insert(5);
            NewList.Insert(10);
            NewList.Insert(15);
            NewList.Insert(20);
            NewList.Insert(25);

            Assert.Equal(true, NewList.Search(NewList.head, 25));
            Assert.Equal(false, NewList.Search(NewList.head, 2));

        }

        [Fact]
        public void ReturnValues()
        {
            LinkedList NewList = new LinkedList();
            NewList.Insert(5);
            NewList.Insert(10);
            NewList.Insert(15);
            NewList.Insert(20);
            NewList.Insert(25);

            string result = NewList.printList();
            Assert.Equal("25-->20-->15-->10-->5-->", result);

        }
    }
}
