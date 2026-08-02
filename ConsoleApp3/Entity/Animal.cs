    using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
    public class Animal
    {
        public string Name {  get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name}はなにか泣こうとしています");
        }
    }




}
