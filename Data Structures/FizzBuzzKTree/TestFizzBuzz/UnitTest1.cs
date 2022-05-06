using FizzBuzzKTree;
using System;
using System.Collections.Generic;
using Xunit;


namespace TestFizzBuzz
{
    public class UnitTest1
    {
        [Fact]
        public void TestFizz()
        {
            FizzBuzzNode first = new FizzBuzzNode(3);
            KTree tree = new KTree(first);
            List<string> expected = new List<string>();
            expected.Add("Fizz");
            Assert.Equal(expected,tree.FizzBuzzTreeMethod(tree));
        }
        [Fact]
        public void TestBuzz()
        {
            FizzBuzzNode first = new FizzBuzzNode(5);
            KTree tree = new KTree(first);
            List<string> expected = new List<string>();
            expected.Add("Buzz");
            Assert.Equal(expected, tree.FizzBuzzTreeMethod(tree));
        }
        [Fact]
        public void TestFizzBuzz()
        {
            FizzBuzzNode first = new FizzBuzzNode(15);
            KTree tree = new KTree(first);
            List<string> expected = new List<string>();
            expected.Add("FizzBuzz");
            Assert.Equal(expected, tree.FizzBuzzTreeMethod(tree));
        }
        [Fact]
        public void TestNotFizzBuzz()
        {
            FizzBuzzNode first = new FizzBuzzNode(7);
            KTree tree = new KTree(first);
            List<string> expected = new List<string>();
            expected.Add("7");
            Assert.Equal(expected, tree.FizzBuzzTreeMethod(tree));
        }
        [Fact]
        public void TestMultiple()
        {
            FizzBuzzNode first = new FizzBuzzNode(5);
            FizzBuzzNode sec = new FizzBuzzNode(6);
            FizzBuzzNode third = new FizzBuzzNode(9);
            FizzBuzzNode fourth = new FizzBuzzNode(15);
            FizzBuzzNode fifth = new FizzBuzzNode(4);
            first.Children.Add(sec);
            first.Children.Add(third);
            first.Children.Add(fourth);
            sec.Children.Add(fifth);

            KTree tree = new KTree(first);
            List<string> expected = new List<string>();
            expected.Add("Buzz");
            expected.Add("Fizz");
            expected.Add("Fizz");
            expected.Add("FizzBuzz");
            expected.Add("4");

            Assert.Equal(expected, tree.FizzBuzzTreeMethod(tree));
        }
    }
}
