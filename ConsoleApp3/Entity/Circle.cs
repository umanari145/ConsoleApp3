using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
    internal class Circle : Shape
    {
        public override int CalculateArea(int radius)
        {
            return radius * radius;
        }
    }
}
