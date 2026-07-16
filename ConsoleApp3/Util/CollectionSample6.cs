using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Util
{
    internal class CollectionSample6
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        List<Person> people = new List<Person>
        {
            new Person { Name = "田中", Age = 25 },
            new Person { Name = "佐藤", Age = 30 },
            new Person { Name = "鈴木", Age = 17 },
            new Person { Name = "高橋", Age = 40 }
        };



        public void output()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            numbers.Where(n => n % 3 == 0).ToList().ForEach(a => Console.WriteLine(a));
            Console.WriteLine("---------------------------------------------------------");
            List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5 };
            numbers2.Select(n => n * n).ToList().ForEach(a => Console.WriteLine(a));
            Console.WriteLine("---------------------------------------------------------");
            List<string> names = new List<string> { "田中", "佐藤", "鈴木", "高橋" };
            names.OrderBy(n => n).ToList().ForEach(a => Console.WriteLine(a));
            Console.WriteLine("---------------------------------------------------------");
            List<int> scores = new List<int> { 80, 65, 90, 72, 55, 100 };
            Console.WriteLine("60点以上の人数" + scores.Where(s => s >= 60).Count());
            Console.WriteLine("合計点" + scores.Sum());
            Console.WriteLine("平均点" + scores.Average());
            Console.WriteLine("最高点" + scores.Max());
            Console.WriteLine("最低点" + scores.Min());
            Console.WriteLine("---------------------------------------------------------");
            List<int> numbers3 = new List<int> { 5, 12, 8, 21, 3, 17 };
            int num = numbers3.FirstOrDefault(n => n >= 10);
            Console.WriteLine(num);
            bool hasOdd = numbers.Any(n => n % 2 != 0);
            Console.WriteLine(hasOdd);
            bool allEven = numbers.All(n => n % 2 == 0);
            Console.WriteLine(allEven);
            Console.WriteLine("---------------------------------------------------------");
            List<int> numbers4 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            numbers4.Where(n=>n %2 == 0).Select(n=>n*3).OrderByDescending(n=>n).ToList()
                .ForEach(n =>Console.WriteLine(n));
            Console.WriteLine("---------------------------------------------------------");
            people.GroupBy(p=>p.Age<=20).Select(p=> new { age= p.Key, Count = p.Count() })
                .ToList().ForEach(p=>Console.WriteLine($"キー{p.age} 人数{p.Count} ")); 

        }
    }
}
