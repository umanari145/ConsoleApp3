using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
    internal class Vehicle
    {
        protected string Name{ get; set; }
        protected int Speed{ get; set; }

        public Vehicle(string Name, int Speed)
        {
            this.Name = Name;
            this.Speed = Speed;
        }

        public virtual void Move()
        {
            Console.WriteLine("移動します");
        }

        public void showInfo()
        {
            Console.WriteLine($"{Name}の最高速度は{Speed}です");
        }
    }

}
