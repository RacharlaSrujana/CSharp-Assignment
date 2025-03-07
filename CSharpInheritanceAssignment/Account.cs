/*
 Sealed Class and Methods
Create a base class `Account` with a virtual method `CalculateInterest()`. Derive a class 
`SavingsAccount` and override `CalculateInterest()`. Now, prevent further overriding by marking
it as `sealed`.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritanceAssignment
{
    class Account
    {
        public int Amount { get; set; }
        public int Time { get; set; }
        public int Rate { get; set; }
        public Account(int amount,int time,int rate)
        {
            Amount = amount;
            Time = time;
            Rate = rate;
        }
        public decimal interest;
        public virtual void CalculateInterest()
        {
            interest = (Amount * Time * Rate) / 100;
            Console.WriteLine($"Interest = {interest}");
        }
    }
    class SavingsAccount : Account
    {
        public SavingsAccount(int amount, int time, int rate) : base(amount, time, rate)
        {
            base.CalculateInterest();
        }

        sealed public override void CalculateInterest()
        {
            Console.WriteLine($"Total amount = {interest+Amount}");
        }
    }
}
