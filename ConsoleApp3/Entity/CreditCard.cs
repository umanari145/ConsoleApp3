using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
    internal class CreditCard: IPyable
    {
        public string CardNumber { get; set; }

        public CreditCard(string cardNumber) 
        {
            CardNumber = cardNumber;
        }


        public void pay(decimal amount)
        {
            Console.WriteLine($" {CardNumber} Paid {amount} using Credit Card");
        }
    }
}
