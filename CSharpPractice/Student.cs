/* Data Hiding with Properties**

Create a `Student` class where `Name` and `RollNo` are private fields. Use properties to enforce 
validation (e.g., `RollNo` cannot be negative, `Name` cannot be empty). */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Student
    {
        string name;
        int roll_number;
        public string NameValidate
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty");
                }
            }
        }
        public int RollNumberValidate
        {
            get { return roll_number; }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Roll number cannot be negative");
                }
                else
                {
                    roll_number = value;
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("Name : " + NameValidate);
            Console.WriteLine("Roll number : " + RollNumberValidate);
        }
    }
}
