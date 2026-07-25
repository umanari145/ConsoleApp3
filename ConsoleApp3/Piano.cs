using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Entity;

namespace ConsoleApp3
{
    internal class Piano : Instrument
    {
        public Piano(string Name, int Price) : base(Name, Price)
        {

        }

        public override void Play()
        {
            Console.WriteLine("タラララ、ピアノを弾きます。");
        }
    }
}
