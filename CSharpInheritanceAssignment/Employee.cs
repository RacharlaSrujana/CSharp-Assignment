/*
 Constructor Chaining in Inheritance
Create a class `Employee` with properties `Name` and `Salary`. Derive a class `Manager` that has 
an additional property `Bonus`. Use constructor chaining to initialize the properties from the base
class.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritanceAssignment
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(string name,double salary)
        {
            Name = name;
            Salary = salary;
        }
    }
    class Manager : Employee
    {
        public double Bonus { set; get; }
        public Manager(string name,double salary,double bonus) : base(name, salary)
        {
            Bonus = bonus;
        }
        public void EmployeeDetails()
        {
            Console.WriteLine($"Employee Details : \n Name : {Name} \n Salary : {Salary} \n Bonus : {Bonus}");
        }
    }
}
