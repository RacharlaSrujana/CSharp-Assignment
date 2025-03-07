using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public interface IVehicle
    {
        void Wheels();
    }
    class VCar : IVehicle
    {
        public void Wheels()
        {
            Console.WriteLine("Car is a four wheeler");
        }
    }
    class VBike : IVehicle
    {
        public void Wheels()
        {
            Console.WriteLine("Bike is a two wheeler");
        }
    }
    class VAuto : IVehicle
    {
        public void Wheels()
        {
            Console.WriteLine("Auto is a three wheeler");
        }
    }
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new VCar();
                case "bike":
                    return new VBike();
                case "auto":
                    return new VAuto();
                default:
                    throw new ArgumentException("No vehicle found");
            }
        }
    }
}
