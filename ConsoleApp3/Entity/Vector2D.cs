using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace ConsoleApp3.Entity
{
    internal class Vector2D
    {
        public double X { get; set; }
        public double Y { get; set; }
    
        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    
        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
