using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinarySearchTree:Tree
    {


        public void Add(int data)
        {
        Node NewNode = new Node(data);

            if (this.Root == null)
            {
                this.Root = NewNode;
            }
            else
            {
                this.InsertNode(this.Root, NewNode);
            }
        }

        public void InsertNode(Node root,Node newNode)
        {
            if (newNode.Value < root.Value)
            {
                if (root.Left == null)
                {
                    root.Left = newNode;
                }
                else
                {
                    this.InsertNode(root.Left, newNode);
                }
            }
            else if (newNode.Value > root.Value)
            {
                if (root.Right == null)
                {
                    root.Right = newNode;
                }
                else
                {
                    this.InsertNode(root.Right, newNode);
                }
            }
        }

        public bool Contains( Node root,int data)
        {
            if (root == null )
            {
                Console.WriteLine("Not Found!");
                return false;
            }
            
            if(root.Value == data)
            {
                Console.WriteLine("Found!");
                return true;
            }

            // Key is greater than root's key
            if (root.Value < data)
                    return Contains(root.Right, data);

                // Key is smaller than root's key
                return Contains(root.Left, data);
            
        }
    }
}
