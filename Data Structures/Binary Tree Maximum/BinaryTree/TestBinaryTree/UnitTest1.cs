using System;
using Xunit;
using BinaryTree;

namespace TestBinaryTree
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyTree()
        {
            Tree tree = new Tree();
            Assert.Null(tree.Root);
        }
        [Fact]
        public void InsertRoot()
        {
            Tree tree = new Tree();
            tree.Root = new Node(1);

            Assert.Equal(1,tree.Root.Value);
        }
        [Fact]

        public void BSTAdd()
        {
            BinarySearchTree treee = new BinarySearchTree();
            treee.Add(5);
            treee.Add(10);
            treee.Add(4);


            Assert.Equal(5, treee.Root.Value);
            Assert.Equal(10, treee.Root.Right.Value);
            Assert.Equal(4, treee.Root.Left.Value);

        }
        [Fact]

        public void PreOrder()
        {
            Tree tree = new Tree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(6);

            object[] expected = new object[] { 1, 2, 4, 5, 3,6 };
            Assert.Equal(expected, tree.Preorder(tree.Root));
            

        }

        [Fact]
        public void InOrder()  
        {
            Tree tree = new Tree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(6);
            object[] expected = new object[] { 4, 2, 5, 1, 6, 3 };
            Assert.Equal(expected, tree.Inorder(tree.Root));

        }
        [Fact]
        public void PostOrder()  
        {
            Tree tree = new Tree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(6);
            object[] expected = new object[] { 4, 5, 2, 6, 3, 1 };
            Assert.Equal(expected, tree.Postorder(tree.Root));

        }

        [Fact]
        public void TestTrue() 
        {
            BinarySearchTree Tree = new BinarySearchTree();

            Tree.Add(5);
            Tree.Add(50);
            Tree.Add(500);
            Assert.True(Tree.Contains(Tree.Root,50));
        }

        [Fact]
        public void TestFalse() 
        {
            BinarySearchTree Tree = new BinarySearchTree();

            Tree.Add(5);
            Tree.Add(50);
            Tree.Add(500);
            Assert.False(Tree.Contains(Tree.Root, 30));

        }

        [Fact]
        public void TestMax()
        {
            Tree tree = new Tree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(6);

            Assert.Equal(6, tree.FindMax(tree.Root));
        }
        [Fact]
        public void TestSameValue()
        {
            Tree tree = new Tree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(6);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(6);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(6);

            Assert.Equal(6, tree.FindMax(tree.Root));
        }
        [Fact]
        public void TestNegative()
        {
            Tree tree = new Tree();
            tree.Root = new Node(-1);
            tree.Root.Left = new Node(-2);
            tree.Root.Right = new Node(-3);
            tree.Root.Left.Left = new Node(-4);
            tree.Root.Left.Right = new Node(-5);
            tree.Root.Right.Left = new Node(-6);

            Assert.Equal(-1, tree.FindMax(tree.Root));
        }
    }
}
