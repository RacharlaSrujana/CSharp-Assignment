using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //BankAccount bankaccount = new BankAccount(1000);
            //bankaccount.Deposit();
            //bankaccount.WithDraw();
            //Console.ReadLine();


            //Student student = new Student();
            //Console.Write("Enter name : ");
            //student.NameValidate = Console.ReadLine();
            //Console.Write("Enter roll number : ");
            //student.RollNumberValidate = Convert.ToInt32(Console.ReadLine());
            //student.Display();
            //Console.ReadLine();


            //Book book1 = new Book();
            //book1.DisplayInfo();
            //Book book2 = new Book("Geetanjali", "Rabindranath Tagore");
            //book2.DisplayInfo();
            //Book book3 = new Book("1101", "Harry Potter", "JK Rowling");
            //book3.DisplayInfo();


            //Rectangle rectangle = new Rectangle(45,20);
            //rectangle.CalculateArea();
            //Circle circle = new Circle(15);
            //circle.CalculateArea();


            //Car car = new Car();
            //car.start();
            //Bike bike = new Bike();
            //bike.start();


            //Teacher teacher = new Teacher("Elisa", 35, 50000, "Mathematics");
            //teacher.GetDetails();
            //StudentClass studentclass = new StudentClass("Bob", 16, 1012);
            //studentclass.GetDetails();


            //Calculator calculator = new Calculator();
            //calculator.Add(10, 76);
            //calculator.Add(80, 20, 28);
            //calculator.Add(15.93, 71.58);


            //MusicPlayer musicplayer = new MusicPlayer();
            //musicplayer.Play();
            //VideoPlayer videoplayer = new VideoPlayer();
            //videoplayer.Play();


            //Report report = new Report();
            //report.Print();
            //report.SaveToFile();



            //Admin admin = new Admin("Admin");
            //admin.UsernameAccess = "admin_456";
            //admin.AccessControl();
            //Customer customer = new Customer("Customer");
            //customer.UsernameAccess = "customer_123";
            //customer.AccessControl();


            //ComplexNumber cn1 = new ComplexNumber(-9, 10);
            //ComplexNumber cn2 = new ComplexNumber(6, 7);
            //ComplexNumber result = cn1 + cn2;
            //Console.WriteLine($"The sum of {cn1} and {cn2} is {result}");


            //Manager mgr1 = new Manager("Alice");
            //Department dept1 = new Department("HR", mgr1);
            //// Shallow Copy
            //Department dept2 = dept1.ShallowCopy();
            //// Deep Copy
            //Department dept3 = dept1.DeepCopy();
            //// Display original & copied objects
            //Console.WriteLine("Before Modification:");
            //dept1.Display();
            //dept2.Display();
            //dept3.Display();
            //// Modify the manager name
            //dept1.DeptManager.Name = "Bob";
            //Console.WriteLine("\nAfter Modifying Original Manager Name:");
            //dept1.Display(); // Manager Name changed
            //dept2.Display(); // Manager Name also changed (Shallow Copy)
            //dept3.Display(); // Manager Name unchanged (Deep Copy)


            //Bank acc1 = new Bank("Alice");
            //Bank acc2 = new Bank("Bob");
            //acc1.GetAccountDetails();
            //acc2.GetAccountDetails();
            //Console.WriteLine("Before modifying interest rate");
            //Bank.setInterestRate(10.5);
            //Console.WriteLine("After modifying interest rate");
            //acc1.GetAccountDetails();
            //acc2.GetAccountDetails();



            //SecuritySystem ss = new SecuritySystem();
            //ss.Authentication();


            //IVehicle car = VehicleFactory.GetVehicle("car");
            //car.Wheels();
            //IVehicle bike = VehicleFactory.GetVehicle("Bike");
            //bike.Wheels();
            //IVehicle auto = VehicleFactory.GetVehicle("Auto");
            //auto.Wheels();
            //IVehicle tractor = VehicleFactory.GetVehicle("tractor");


            //ShoppingCart cart = new ShoppingCart();
            //cart.AddItem(100);
            //cart.AddItem(200);
            //Console.WriteLine("Choose a discount strategy: 1. No Discount 2. Percentage Discount 3. Fixed Amount Discount");
            //int option = int.Parse(Console.ReadLine());
            //switch (option)
            //{
            //    case 1:
            //        cart.SetDiscountStrategy(new NoDiscount());
            //        break;
            //    case 2:
            //        Console.WriteLine("Enter the discount percentage:");
            //        decimal percentage = decimal.Parse(Console.ReadLine());
            //        cart.SetDiscountStrategy(new PercentageDiscount(percentage));
            //        break;
            //    case 3:
            //        Console.WriteLine("Enter the discount amount:");
            //        decimal amount = decimal.Parse(Console.ReadLine());
            //        cart.SetDiscountStrategy(new FixedAmountDiscount(amount));
            //        break;
            //    default:
            //        Console.WriteLine("Invalid choice. No discount will be applied.");
            //        cart.SetDiscountStrategy(new NoDiscount());
            //        break;
            //}
            //decimal totalAmount = cart.CalculateTotal();
            //Console.WriteLine($"Total amount after discount: {totalAmount}");
        }
    }
}
