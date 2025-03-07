/* Encapsulation Challenge**

Create a `BankAccount` class where `balance` is a private field. Implement methods for `Deposit()` and 
`Withdraw()`, ensuring that withdrawal is only allowed if there is a sufficient balance. Prevent direct
modification of `balance` from outside the class. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class BankAccount
    {
        private int Balance;
        public BankAccount(int Balance)
        {
            this.Balance = Balance;
        }
        public void Deposit()
        {
            Console.Write("Enter amount to deposit : ");
            int deposit_amnt = Convert.ToInt32(Console.ReadLine());
            Balance += deposit_amnt;
            Console.WriteLine("Balance after deposit : "+Balance);
        }
        
        public void WithDraw()
        {
            Console.Write("Enter amount to withdraw : ");
            int withdraw_amnt = Convert.ToInt32(Console.ReadLine());
            if (withdraw_amnt > Balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Balance -= withdraw_amnt;
                Console.WriteLine("Balance after withdraw : "+Balance);
            }
        }
    }
}
