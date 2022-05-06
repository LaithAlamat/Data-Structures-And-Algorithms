using FizzBuzzKTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKTree
{
    public class KTree
    {
        public FizzBuzzNode Root;
       
        public KTree(FizzBuzzNode newNode)
        {
            Root = newNode;

        }
        public List<string> FizzBuzzTreeMethod(KTree MyKTree)
        {

            Queue<FizzBuzzNode> MyQueue = new Queue<FizzBuzzNode>();
            List<string> MyList = new List<string>();
            if (MyKTree.Root == null)
            {
                throw new Exception("The Tree Is Empty!!");
            }
            else
            {
                MyQueue.Enqueue(MyKTree.Root);
                while (MyQueue.Count > 0)
                {
                    FizzBuzzNode temp = MyQueue.Dequeue();
                    if (temp.Value % 3 == 0 && temp.Value % 5 == 0)
                    {
                        MyList.Add("FizzBuzz");
                    }


                    else if (temp.Value % 3 == 0)
                    {
                        MyList.Add("Fizz");
                    }
                    else if (temp.Value % 5 == 0)
                    {
                        MyList.Add("Buzz");
                    }

                    else
                    {
                        MyList.Add(temp.Value.ToString());
                    }
                    if (temp.Children.Count > 0)
                    {
                        foreach (var child in temp.Children)
                        {
                            MyQueue.Enqueue(child);
                        }
                    }
                }

                foreach(var item in MyList)
                {
                    Console.WriteLine(item);
                }
                return MyList;

            }
        }

     }

}
