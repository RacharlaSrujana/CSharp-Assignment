/*
 Real-World Scenario: E-Commerce System
Create a base class `Product` with properties `Name` and `Price`. Derive two classes 
`ElectronicProduct` and `ClothingProduct`. Add a `GetDiscountedPrice()` method in the base class
and override it in the derived classes to apply different discount rules.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritanceAssignment
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public virtual void GetDiscountedPrice()
        {
            Console.WriteLine("Discount varies according to the type of product");
        }
    }
    class ElectronicProduct:Product
    {
        public ElectronicProduct(string name, int price) : base(name, price)
        {
        }

        public override void GetDiscountedPrice()
        {
            Console.WriteLine("Electronic products have 40% discount");
            Console.WriteLine($"Actual price : {Price}");
            Console.WriteLine($"Total amount after discount : {Price-(40.0m/100)*Price}");
        }
    }
    class ClothingProduct:Product
    {
        public ClothingProduct(string name, int price) : base(name, price)
        {
        }

        public override void GetDiscountedPrice()
        {
            Console.WriteLine("Clothing products have 15% discount");
            Console.WriteLine($"Actual price : {Price}");
            Console.WriteLine($"Total amount after discount : {Price - (15.0m / 100) * Price}");
        }
    }
}
