/* Using Virtual Methods in Inheritance**
Create a `Person` base class with a `GetDetails()` method. Derive `Student` and `Teacher` 
classes that override `GetDetails()` to display their respective properties. Call `GetDetails()` 
using a base class reference. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Person
    {
        protected string name;
        protected int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void GetDetails()
        {
            Console.WriteLine($"Name : {this.name}    Age : {this.age}");
        }
    }
    class Teacher : Person
    {
        int salary;
        string subject;
        public Teacher(string name, int age,int salary,string subject) : base(name, age)
        {
            this.salary = salary;
            this.subject = subject;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Teacher Details \n Name : {name} \n Age : {age} \n Salary : {this.salary} \n Subject : {this.subject}");
        }
    }
    class StudentClass : Person
    {
        int rollNumber;
        public StudentClass(string name, int age,int rollNumber):base(name,age)
        {
            this.rollNumber = rollNumber;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Student Details \n Roll Number : {this.rollNumber} \n Name : {name} \n Age : {age}");
        }
    }
}
