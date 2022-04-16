using Class12;
using System;
using System.Collections.Generic;
using static Class12.AnimalShelter;

namespace Animalshelter
{
    public class Program
    {

        static void Main(string[] args)
        {
            AnimalShelter shelter = new AnimalShelter();
        Animal dog = new Animal("dog");
            Animal cat = new Animal("cat");


            shelter.EnqueueAnimal(dog);
            shelter.EnqueueAnimal(cat);

            shelter.DequeueAnimal("cat");





        }
    }
}