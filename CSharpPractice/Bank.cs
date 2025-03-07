using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Bank
    {
        public static double interestRate { get; private set; } = 5.0;
        public string AccountHolder;
        public Bank(string accountholder)
        {
            AccountHolder = accountholder;
        }
        public static void setInterestRate(double newInterestRate)
        {
            interestRate = newInterestRate;
            Console.WriteLine($"Interest rate is updated to {interestRate}%");
        }
        public void GetAccountDetails()
        {
            Console.WriteLine($"Account holder : {AccountHolder}, Interest Rate : {interestRate}%");
        }
    }
}
