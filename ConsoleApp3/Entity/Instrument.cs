using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
    public abstract class Instrument
    {
        protected string Name { get; set; }
        protected int Price { get; set; }


        protected Instrument(string Name, int Price) { 
            this.Name = Name;
            this.Price = Price;
        }

        public abstract void Play();

        public void showInfo()
        {
            Console.Write($"{Name} (価格:{Price}円)");
        }
    }
}
