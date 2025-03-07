/*
 Method Overriding and Base Keyword
Modify the `DisplayInfo()` method in `Vehicle` to print `Brand` and `Speed`. Override this method 
in `Car` and `Bike` to include additional specific information. Ensure the base class method is 
called using `base.DisplayInfo()`.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritanceAssignment
{
    class VehicleOverride
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public VehicleOverride(string name, string brand)
        {
            Name = name;
            Brand = brand;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Different vehicles have different brands and names");
        }
    }
    class CarOverride : VehicleOverride
    {
        int Seats;
        public CarOverride(string Name,string Brand,int seats) : base(Name, Brand)
        {
            Seats = seats;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Car Details :\n Name : {Name}\n Brand : {Brand}\n Seats : {Seats}");
        }
    }
    class BikeOverride : VehicleOverride
    {
        public int Milage { get; set; }
        public BikeOverride(string name, string brand,int milage) : base(name, brand)
        {
            Milage = milage;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Bike Details :\n Name : {Name}\n Brand : {Brand}\n Milage : {Milage}");
        }
    }
}
