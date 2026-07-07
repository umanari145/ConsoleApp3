using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
    internal class Counter
    {
        public static int Count { get; private set; }

        public Counter()
        {
            Count++;
        }
    }
}
