using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Util
{
    internal class Generics<T>
    {
        private T content;

        public void set(T item)
        {
            this.content = item;
        }

        public T get()
        { 
            return this.content; 
        }
    }
}
