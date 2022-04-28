using Breadth_First_Traversal;
using System;
using System.Collections.Generic;
using Xunit;

namespace BreadthTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestEmpty()
        {
            Tree tree = new Tree();
            List<int> expected = new List<int> { };
            List<int> result = Program.BreadthFirst(tree.Root);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestTree1()
        {
            Tree tree = new Tree();
            tree.Root = new Node(2);
            tree.Root.Left = new Node(7);
            tree.Root.Right = new Node(5);
            tree.Root.Left.Left = new Node(2);
            tree.Root.Left.Right = new Node(6);
            tree.Root.Right.Right = new Node(9);
            tree.Root.Left.Right.Left = new Node(5);
            tree.Root.Left.Right.Right = new Node(11);
            tree.Root.Right.Right.Left = new Node(4);

            List<int> expected = new List<int> { 2, 7, 5, 2, 6, 9, 5, 11, 4 };
            List<int> result = Program.BreadthFirst(tree.Root);
            Assert.Equal(expected, result);
        }
    }
}
