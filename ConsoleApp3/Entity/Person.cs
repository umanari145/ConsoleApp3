using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
    internal class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
 
        public void introduce()
        {
            Console.WriteLine($"私の名前は{Name}です。年齢は{Age}歳です。");
        }
    }
}
