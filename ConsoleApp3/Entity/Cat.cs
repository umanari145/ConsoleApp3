using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {   
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name}はニャーニャーとないています。");
        }
    }
}
