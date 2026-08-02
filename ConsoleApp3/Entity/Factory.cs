using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
    public class Factory<T> where T : Animal
    {
        T entitiy;

        public Factory(T entitiy)
        {
            this.entitiy = entitiy;
        }

        public void samplevoid()
        {
            this.entitiy.MakeSound();
        }
    }
}
