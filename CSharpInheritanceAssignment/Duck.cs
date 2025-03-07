/*
 Multiple Inheritance Using Interfaces
Create two interfaces `IFlyable` and `ISwimmable` with methods `Fly()` and `Swim()`, respectively. 
Implement these interfaces in a class `Duck` to exhibit both behaviors.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritanceAssignment
{
    interface IFlyable
    {
        public void Fly();
    }
    interface ISwimmable
    {
        public void Swim();
    }
    class Duck:IFlyable,ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("Ducks can fly");
        }
        public void Swim()
        {
            Console.WriteLine("Ducks can swim");
        }
    }
}
