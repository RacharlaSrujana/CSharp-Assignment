/* Abstraction with Abstract Classes

Design an abstract class `Shape` with an abstract method `CalculateArea()`. 
Create derived classes `Circle` and `Rectangle` that implement this method. 
Demonstrate abstraction by instantiating these classes. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    abstract class Shape
    {
        public abstract void CalculateArea();
    }
    class Rectangle : Shape
    {
        int length, breadth;
        public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public override void CalculateArea()
        {
            Console.WriteLine($"Area of rectangle : {length*breadth}");
        }
    }
    class Circle : Shape
    {
        int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override void CalculateArea()
        {
            Console.WriteLine($"Area of circle : {3.14 * radius*radius:F2}");
        }
    }
}
