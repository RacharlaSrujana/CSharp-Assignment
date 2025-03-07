/* Shallow Copy vs. Deep Copy

Create a `Department` class with a reference-type property `Manager`. 
Implement both **Shallow Copy** and **Deep Copy** to show how references are handled. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Manager
    {
        public string Name { get; set; }
        public Manager(string name)
        {
            Name = name;
        }
    }
    class Department
    {
        public string DeptName { get; set; }
        public Manager DeptManager { get; set; }

        public Department(string deptName, Manager deptManager)
        {
            DeptName = deptName;
            DeptManager = deptManager;
        }
        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone();
        }
        public Department DeepCopy()
        {
            return new Department(this.DeptName, new Manager(this.DeptManager.Name));
        }
        public void Display()
        {
            Console.WriteLine($"Department : {DeptName}, Manager : {DeptManager.Name}");
        }
    }
}
