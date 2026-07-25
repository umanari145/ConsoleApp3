using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
    internal class AirPlane:Vehicle
    {
        public int MaxAltitude { get; set; }

        public AirPlane(string Name, int Speed, int MaxAlititude)
            :base(Name , Speed)
        {
            this.MaxAltitude = MaxAltitude;
        }

        public override void Move()
        {
            Console.WriteLine("空を飛びます。");
        }
    }
}
