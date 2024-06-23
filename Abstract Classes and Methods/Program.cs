using System;

namespace AbstractClassDemo
{
    // Abstract class Shape
    abstract class Shape
    {
        // Abstract method GetArea
        public abstract double GetArea();
    }

    // Derived class Circle
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Implementing the GetArea method
        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    // Derived class Rectangle
    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Implementing the GetArea method
        public override double GetArea()
        {
            return width * height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Circle and Rectangle
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            // Display their areas
            Console.WriteLine($"Area of Circle: {circle.GetArea()}");       // Output: Area of Circle: 78.53981633974483
            Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}"); // Output: Area of Rectangle: 24

            // Wait for user input to close the console window
            Console.ReadLine();
        }
    }
}

