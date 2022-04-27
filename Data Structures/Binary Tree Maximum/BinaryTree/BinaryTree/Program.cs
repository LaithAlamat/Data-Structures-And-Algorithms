using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(5);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(7);
            tree.Root.Left.Right = new Node(11);
            tree.Root.Right.Left = new Node(6);

            Console.WriteLine("\nInorder traversal of binary tree is ");
            tree.Inorder();
            tree.Postorder();
            tree.Preorder();

            BinarySearchTree treee = new BinarySearchTree();
            treee.Add(5);
            treee.Add(10);
            treee.Add(15);
            treee.Add(20);
            treee.Add(25);
            treee.Add(30);
            treee.Add(35);
            treee.Contains(treee.Root, 3);

            Console.WriteLine("Maximum element is "
                          + tree.FindMax(tree.Root));

        }
    }
}
