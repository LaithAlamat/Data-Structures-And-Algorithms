using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree
    {
        public Node Root { get; set; }
        public List<object> List = new List<object>();

        public Tree()
        {
            Root = null;
        }

        public Node GetRoot()
        {
            return Root;
        }
        public void Inorder()
        {
            Inorder(Root);
            Console.WriteLine("");
        }
        public object[] Inorder(Node node)
        {
            if (node == null)
                return null;

            
            Inorder(node.Left);
            List.Add(node.Value);
            Console.Write(node.Value + " ");
            Inorder(node.Right);
            return List.ToArray();

        }

        public void Preorder() {
            Preorder(Root);
            Console.WriteLine("");

        }
        public object[] Preorder(Node node)
        {
            if (node == null)
                return null;

            List.Add(node.Value);
            Console.Write(node.Value + " ");
            Preorder(node.Left);
            Preorder(node.Right);
            return List.ToArray();

        }



        public void Postorder() 
        {
            Postorder(Root); 
            Console.WriteLine("");

        }
        public object[] Postorder(Node node)
        {
            if (node == null)
                return null;


            Postorder(node.Left);
            Postorder(node.Right);
            List.Add(node.Value);
            Console.Write(node.Value + " ");
            return List.ToArray();
        }

       
        public int FindMax(Node node)
        {
            if (node == null)
            {
                return int.MinValue;
            }

            int Max = node.Value;
            int left = FindMax(node.Left);
            int right = FindMax(node.Right);

            if (left > Max)
            {
                Max = left;
            }
            if (right > Max)
            {
                Max = right;
            }
            return Max;
        }

    }
}
