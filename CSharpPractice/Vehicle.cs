/* Method Overriding for a Vehicle System

Create a base class `Vehicle` with a method `Start()`. Override it in `Car` and `Bike` 
classes to provide specific implementations. Use the `override` keyword and demonstrate 
polymorphism. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Vehicle
    {
        public virtual void start()
        {
            Console.WriteLine("The vehicle has started");
        }
    }
    class Car : Vehicle
    {
        public override void start()
        {
            Console.WriteLine("Car has started");
        }
    }
    class Bike : Vehicle
    {
        public override void start()
        {
            Console.WriteLine("Bike has started");
        }
    }
}
