/* Method Overloading in a Calculator Class**
Implement a `Calculator` class with overloaded methods `Add()`. It should accept two integers, 
three integers, and two double values separately. Demonstrate how method overloading works. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Calculator
    {
        public void Add(int num1,int num2)
        {
            Console.WriteLine($"Sum = {num1+num2}");
        }
        public void Add(int num1,int num2,int num3)
        {
            Console.WriteLine($"Sum = {num1+num2+num3}");
        }
        public void Add(double num1,double num2)
        {
            Console.WriteLine($"Sum = {num1+num2:F3}");
        }
    }
}
