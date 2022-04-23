using Class12;
using System;
using Xunit;
using static Class12.AnimalShelter;

namespace ShelterTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestEnqueue()
        {
            AnimalShelter test = new AnimalShelter();

            Animal dog = new Animal("dog");
            test.EnqueueAnimal(dog);
            Assert.Equal(dog.type,AnimalShelter.Animal.Dog.type);
        }
        [Fact]
        public void TestDequeue()
        {
            AnimalShelter test = new AnimalShelter();
            Animal dog = new Animal("dog");
            Animal cat = new Animal("cat");

            test.EnqueueAnimal(cat);
            test.DequeueAnimal("cat");

            Assert.Equal("cat", test.DequeueAnimal("cat"));

        }

        [Fact]
        public void TestNotCatOrDog()
        {
            AnimalShelter test = new AnimalShelter();
            Animal cat = new Animal("cat");
            Animal duck = new Animal("duck");


            test.EnqueueAnimal(cat);
            test.EnqueueAnimal(duck);
            test.DequeueAnimal("cat");

            Assert.Equal("", test.EnqueueAnimal(duck));

        }

        [Fact]
        public void DequeueNotCatOrDog()
        {
            AnimalShelter test = new AnimalShelter();
            Animal dog = new Animal("dog");
            Animal cat = new Animal("cat");

            test.EnqueueAnimal(cat);
            test.DequeueAnimal("duck");

            Assert.Equal("", test.DequeueAnimal("duck"));

        }
    }
}
