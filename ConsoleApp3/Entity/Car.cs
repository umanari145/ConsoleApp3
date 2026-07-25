using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
    internal class Car: Vehicle
    {
        public int WheelCount {  get; set; }

        public Car(string Name, int Speed, int WheelCount): base( Name,  Speed){ 
            this.WheelCount = WheelCount;
        }

        public override void Move()
        {
            Console.WriteLine("道路を走ります。");
        }


    }
}
