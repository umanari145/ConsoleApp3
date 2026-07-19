using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Util
{
    internal class CollectionSample9
    {


        List<int> number = new List<int>{ 5, 3, 8, 1, 9, 2 };
        List<string> words = new List<string> { "apple", "banana", "fig", "grape", "kiwi" };
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        List<int> numbers2 = new List<int> { 10, 20, 30};
        HashSet<string> animals = new HashSet<string> { "cat", "dog", "cat", "bird", "dog", "cat" };
    class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        class Product
        {
            public string Category { get; set; }
            public decimal Price { get; set; }
        }

        List<Product> products = new List<Product>
        {
            new Product { Category = "食品",   Price = 300m },
            new Product { Category = "食品",   Price = 150m },
            new Product { Category = "食品",   Price = 500m },
            new Product { Category = "家電",   Price = 12000m },
            new Product { Category = "家電",   Price = 8000m },
            new Product { Category = "衣類",   Price = 3000m },
            new Product { Category = "衣類",   Price = 4500m },
            new Product { Category = "衣類",   Price = 2000m },
            new Product { Category = "書籍",   Price = 1200m },
        };


        List<Person> persons = new List<Person>
        {
            new Person { Name = "田中",   Age = 25 },
            new Person { Name = "鈴木",   Age = 17 },
            new Person { Name = "佐藤",   Age = 32 },
            new Person { Name = "高橋",   Age = 19 },
            new Person { Name = "伊藤",   Age = 45 },
            new Person { Name = "渡辺",   Age = 22 },
            new Person { Name = "山本",   Age = 15 },
        };
        public void output() {
            number.Where(n => n % 2 == 0)
                .OrderBy(n=>n)
                .ToList()
                .ForEach(n => Console.WriteLine(n));
            Console.WriteLine("-----------------------------------------------");
            words.Where(w=>w.Count() >= 5).ToList() .
                ForEach(w => Console.WriteLine(w));

            Console.WriteLine("平均値" + numbers.Average(n => n));
            Console.WriteLine("合計値" + numbers.Sum(n => n));
            Console.WriteLine("-----------------------------------------------");
            numbers2.Select(n=>n*2).ToList().ForEach(n => Console.WriteLine(n));
            Console.WriteLine("-----------------------------------------------");
            persons.Where(p=>p.Age >= 20).
                OrderByDescending(p=>p.Age)
                .Select(p=>p.Name).ToList().ForEach(n => Console.WriteLine(n));
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(persons.MaxBy(p => p.Age).Name);
            Console.WriteLine("-----------------------------------------------");
            animals.ToList().ForEach(n => Console.WriteLine(n));
            persons.GroupBy(p => (p.Age / 10) * 10)
                .OrderBy(g => g.Key)
                .Select(g=> new {Age = g.Key, Count = g.Count()})
                .ToList().ForEach(n => Console.WriteLine(n.Age + " " + n.Count));
            Console.WriteLine("-----------------------------------------------");

            products.GroupBy(p => p.Category)
                .Select(p => new
                {
                    category = p.Key,
                    sum = p.Sum(p => p.Price)
                }).ToList().ForEach(n => Console.WriteLine(n.category + " " + n.sum));



        }
    }
}
