/*
 Interface vs Inheritance in C#
Create an interface `IMovable` with a method `Move()`. Implement this interface in a `Robot` class.
Also, create a base class `Machine` with a method `Start()`. Have `Robot` inherit from `Machine` 
and implement `IMovable`.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritanceAssignment
{
    interface IMovable
    {
        public void Move();
    }
    class Machine
    {
        public void start()
        {
            Console.WriteLine("Robot can be started using button");
        }
    }
    class Robot : Machine,IMovable
    {
        public void Move()
        {
            Console.WriteLine("Robot is moving");
        }
    }
}
