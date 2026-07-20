using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Reflection;
namespace ConsoleApp3.Entity
{
    internal class Reflection
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; } = 25;

            public int Add(int a, int b)
            {
                return a + b;
            }

            public void SayHello()
            {
                Console.WriteLine($"Hello, my name is {Name}");
            }

            private void SecretMethod()
            {
                Console.WriteLine("This is private");
            }
        }

        public void reflection()
        {
            Type type = typeof(Person);
            object obj = Activator.CreateInstance(type);

            Console.WriteLine($"クラス名: {type.Name}");
            Console.WriteLine($"名前空間: {type.Namespace}");
            Console.WriteLine($"アセンブリ: {type.Assembly.GetName().Name}");

            PropertyInfo ageProp = type.GetProperty("Age");
            object value = ageProp.GetValue(obj);
            Console.WriteLine($"Age: {value}");

            MethodInfo add = type.GetMethod("Add");
            object result = add.Invoke(obj, new object[] { 3, 5 });
            Console.WriteLine($"Add結果: {result}");

            MethodInfo secret = type.GetMethod("SecretMethod",
            BindingFlags.NonPublic | BindingFlags.Instance);
            secret.Invoke(obj, null);
        }


    }
}
