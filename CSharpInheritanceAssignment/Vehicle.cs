/*
 Implement a Basic Inheritance Hierarchy
Create a base class `Vehicle` with properties `Brand` and `Speed`. Derive two classes `Car` and 
`Bike` from `Vehicle`. Add a method `DisplayInfo()` in `Vehicle` that should be accessible in the
derived classes.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritanceAssignment
{
    class Vehicle
    {
        public string Brand,Speed;
        public void DisplayInfo()
        {
            Console.WriteLine("Every vehicle has speed and brand");
        }
    }
    class Bike : Vehicle
    {
        public Bike()
        {
            base.DisplayInfo();
        }
    }
    class Car : Vehicle
    {
        public Car()
        {
            base.DisplayInfo();
        }
    }
}
