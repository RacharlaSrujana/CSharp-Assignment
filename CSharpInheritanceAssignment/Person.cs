/*
 Upcasting and Downcasting
Create a base class `Person` and derive a class `Student`. Create an object of `Student`, upcast 
it to `Person`, and then downcast it back to `Student`. Demonstrate how type casting works.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritanceAssignment
{
    class Person
    {
        public string Name;
        public int age;
        public Person(string name, int age)
        {
            Name = name;
            this.age = age;
        }
        public void PersonDetails()
        {
            Console.WriteLine($"Person details : \n Name : {Name} \n Age:{age}");
        }
    }
    class Student : Person
    {
        String Course;
        int RollNo;
        public Student(string name, int age,string course,int rollno) : base(name, age)
        {
            Course = course;
            RollNo = rollno;
        }

        public void StudentDetails()
        {
            Console.WriteLine($"Student Details : \n Roll Number : {RollNo} \n Name : {Name} \n Age : {age} \n Course : {Course}");
        }
    }
}
