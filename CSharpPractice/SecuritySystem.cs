/* Sealed Class in a Security System

Create a sealed class `SecuritySystem` that prevents inheritance. 
Show how sealing a class stops further extension. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    sealed class SecuritySystem
    {
        public void Authentication()
        {
            Console.WriteLine("User authentication successful");
        }
    }
    //class TestClass : SecuritySystem
    //{
    //    public void Display()
    //    {
    //        Console.WriteLine("Sealed class prevents further inheritance, it raises an error");
    //    }
    //}
}
