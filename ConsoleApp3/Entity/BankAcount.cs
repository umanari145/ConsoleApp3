using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
    internal class BankAcount
    {
        private int Balance { get; set; }

        public void Deposit(int amount)
        {
            Balance += amount;
        }

        public void withdraw(int amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("残高不足です。");
            }
        }
    }
}
