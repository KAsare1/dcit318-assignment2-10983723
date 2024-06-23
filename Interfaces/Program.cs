using System;

namespace InterfaceDemo
{
    // Define an interface IMovable
    interface IMovable
    {
        void Move();
    }

    // Class Car implementing IMovable
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving!");
        }
    }

    // Class Bicycle implementing IMovable
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Car and Bicycle
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            // Call the Move() method on each instance
            car.Move();      // Output: Car is moving
            bicycle.Move();  // Output: Bicycle is moving

            // Wait for user input to close the console window
            Console.ReadLine();
        }
    }
}
