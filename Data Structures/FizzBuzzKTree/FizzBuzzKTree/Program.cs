using System;

namespace FizzBuzzKTree
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzNode first = new FizzBuzzNode(5);
            FizzBuzzNode sec = new FizzBuzzNode(6);
            FizzBuzzNode third = new FizzBuzzNode(9);
            FizzBuzzNode fourth = new FizzBuzzNode(15);
            FizzBuzzNode fifth = new FizzBuzzNode(4);
            first.Children.Add(sec);
            first.Children.Add(third);
            first.Children.Add(fourth);
            first.Children.Add(fifth);

            KTree tree = new KTree(first);
            tree.FizzBuzzTreeMethod(tree);
        }
    }
}
