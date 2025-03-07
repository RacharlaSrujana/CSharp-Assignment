/*
 Abstract Class and Polymorphism
Create an abstract class `Animal` with an abstract method `MakeSound()`. Derive two classes `Dog`
and `Cat` that override `MakeSound()`. Instantiate objects of both classes and call the method.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritanceAssignment
{
    abstract class Animal
    {
        public abstract void MakeSound();
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog is barking");
        }
    }
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat says meow");
        }
    }
}
