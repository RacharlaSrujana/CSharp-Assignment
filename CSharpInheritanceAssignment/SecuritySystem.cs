/*
 Prevent Inheritance Using Sealed Class
Create a `sealed` class `SecuritySystem` with a method `AuthenticateUser()`. Try to derive a class 
from it and observe the compiler error. Explain why `sealed` is useful in real-world applications.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritanceAssignment
{
    sealed class SecuritySystem
    {
        public void AuthenticateUser()
        {
            Console.WriteLine("User authentication successful");
        }
    }

    //sealed keyword is used to prevent further inheritance. So it raises an error while trying to inherit a sealed class

    //class TestSealedClass : SecuritySystem
    //{
    //    public void Test()
    //    {
    //        Console.WriteLine("Cannot inherit sealed class");
    //    }
    //}
}
