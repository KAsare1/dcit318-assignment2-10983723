using System;

namespace OOPDemo
{
    // Base class
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark!");
        }
    }

    // Derived class Cat
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Animal, Dog, and Cat
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Call the MakeSound() method on each instance
            genericAnimal.MakeSound(); // Output: Some generic sound
            dog.MakeSound();           // Output: Bark
            cat.MakeSound();           // Output: Meow

            // Wait for user input to close the console window
            Console.ReadLine();
        }
    }
}

