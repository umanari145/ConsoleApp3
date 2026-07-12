using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Util
{
    internal class CollectionSample3
    {
        public class Animal
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Species { get; set; }
            public int Age { get; set; }
            public double WeightKg { get; set; }
        }

        List<Animal> animals = new List<Animal>
        {
            new Animal { Id = 1, Name = "パンダ太郎", Species = "パンダ", Age = 5, WeightKg = 90 },
            new Animal { Id = 2, Name = "ライオン花子", Species = "ライオン", Age = 8, WeightKg = 150 },
            new Animal { Id = 3, Name = "キリン次郎", Species = "キリン", Age = 3, WeightKg = 800 },
            new Animal { Id = 4, Name = "ゾウ三郎", Species = "ゾウ", Age = 12, WeightKg = 4000 },
            new Animal { Id = 5, Name = "パンダ花子", Species = "パンダ", Age = 2, WeightKg = 60 },
            new Animal { Id = 6, Name = "ライオン太郎", Species = "ライオン", Age = 1, WeightKg = 40 },
            new Animal { Id = 7, Name = "サル次郎", Species = "サル", Age = 6, WeightKg = 15 },
            new Animal { Id = 8, Name = "ペンギン花子", Species = "ペンギン", Age = 4, WeightKg = 5 },
        };

        public void collectionOutput()
        {
            animals.Where(a => a.Age >= 5).ToList().ForEach(a => { Console.WriteLine($"{a.Name} 年齢{a.Age}"); });
            Console.WriteLine("---------------------------------------------------------");
            animals.Select(a => a.Name).ToList().ForEach(a => { Console.WriteLine($"{a}"); });
            Console.WriteLine("---------------------------------------------------------");
            animals.Where(a=>a.WeightKg>=100)
                    .Select(a=>a.Name)
                    .ToList().ForEach(a => { Console.WriteLine($"{a}"); });
            Console.WriteLine("---------------------------------------------------------");
            animals.OrderBy(a => a.WeightKg).ToList().ForEach(a => { Console.WriteLine($"{a.Name} 体重{a.WeightKg}");});
            Console.WriteLine("---------------------------------------------------------");
            animals.OrderByDescending(a=>a.Age).ToList().ForEach(a => { Console.WriteLine($"{a.Name}　年齢{a.Age}"); });
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("パンダの頭数" + animals.Where(a => a.Species == "パンダ").Count());
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("全動物の重さ" + animals.Sum(a => a.WeightKg));
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("動物の平均年齢" + animals.Average(a => a.Age));
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("動物の最大体重/最低体重" + animals.Max(a => a.WeightKg) +"/"+ animals.Min(a=>a.WeightKg));
            Console.WriteLine("---------------------------------------------------------");
            animals.Where(a=>a.Species == "ライオン").OrderByDescending(a=>a.Age).Take(1).ToList().ForEach(a => { Console.WriteLine($"{a.Name} 年齢 {a.Age}"); });
        }
    }
}
