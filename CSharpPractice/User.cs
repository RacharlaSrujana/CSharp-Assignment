/* Design a Role-Based Access System

Create a base class `User` with properties like `Username` and `Role`. Derive `Admin` and `Customer`
classes that override a method `AccessControl()`, where `Admin` can access all features, but `Customer`
has limited access. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class User
    {
        public string Username, Role;
        public string UsernameAccess
        {
            get { return Username; }
            set
            {
                if (Role == "Admin")
                {
                    Username = value;
                }
                else
                {
                    Console.WriteLine("cannot edit username");
                }
            }
        }
        public User(string username,string role)
        {
            Role = role;
            Username =username;
        }
        public virtual void AccessControl()
        {
            Console.WriteLine("Access is given to user based on the role");
        }
    }
    class Admin:User
    {
        public Admin(string role) : base("admin@123",role) { }
        public override void AccessControl()
        {
            base.AccessControl();
            Console.WriteLine($"{Role} : {UsernameAccess}, role has access to all features");
        }
    }
    class Customer:User
    {
        public Customer(string role) : base("customer123",role) { }
        public override void AccessControl()
        {
            Console.WriteLine($"{Role} : {UsernameAccess}, has limited access");
        }
    }
}
