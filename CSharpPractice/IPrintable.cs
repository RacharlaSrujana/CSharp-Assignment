/* Multiple Inheritance Using Interfaces

Define two interfaces `IPrintable` (for printing details) and `ISerializable` 
(for saving to a file). Implement both in a `Report` class and demonstrate multiple interface 
implementation. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    interface IPrintable
    {
        void Print();
    }
    interface ISerializable
    {
        void SaveToFile();
    }
    class Report : IPrintable, ISerializable
    {
        public void Print()
        {
            Console.WriteLine("The content is printing");
        }
        public void SaveToFile()
        {
            Console.WriteLine("The content is saved to a file");
        }
    }
}
