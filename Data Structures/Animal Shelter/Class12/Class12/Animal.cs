using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Class12.Node;

namespace Class12
{


    public class AnimalShelter
    {
        Queue cat = new Queue();
        Queue dog = new Queue();


        public string EnqueueAnimal(Animal animal)
        {
            switch (animal.type)
            {
                case "cat":
                    Console.WriteLine("A Cat was sheltered");
                    cat.enqueue(animal);
                    return "cat";
                case "dog":
                    Console.WriteLine("A Dog was sheltered");
                    dog.enqueue(animal);
                    return "dog";

                default: 
                    Console.WriteLine("this animal can't be sheltered here.");
                    return "";

            }
        }

        public string DequeueAnimal(string animal)
        {
            switch (animal)
            {
                case "cat":
                    Console.WriteLine("A Cat was removed from the shelter");
                    cat.dequeue(animal);
                    return animal;
                case "dog":
                    Console.WriteLine("A Dog was removed from the shelter");
                    dog.dequeue(animal);
                    return animal;
                default:
                    Console.WriteLine("this animal is not in the shelter.");
                    return "";
            }



        }

        public class Animal {

            public string type;

            public Animal(string type)
            {
                this.type = type;
            }
            public static Animal Cat = new Animal("cat");
            public static Animal Dog = new Animal("dog");

        }
    }
}
