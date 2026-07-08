using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Util
{
    internal class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name}が泣きました。");
        }
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name}がワンワンと鳴きました。");
        }
    }

    class AnilaShelter<T> where T : Animal
    {

        //nullable reference typeを許可するためにT?を使用
        // これをいれないとrequiredなプロパティとして扱われるため、nullを許容する場合はT?を使用する必要がある
        public T?  Animal;

        public void AddAnimal(T animal)
        {
             Animal = animal;
        }

        public void AnnnounceAnimalSound()
        {
            Animal.MakeSound();

        }
    }
}
