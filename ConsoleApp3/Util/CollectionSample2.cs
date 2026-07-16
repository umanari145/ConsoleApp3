using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp3.Util
{
    internal class CollectionSample2
    {
        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Stock { get; set; }
            public int CategoryId { get; set; }
        }

        public class Author
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Book
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public int AuthorId { get; set; }
            public int PublishedYear { get; set; }
        }

        public class Loan
        {
            public int Id { get; set; }
            public int BookId { get; set; }
            public string BorrowerName { get; set; }
            public DateTime LoanDate { get; set; }
            public DateTime? ReturnDate { get; set; } // null = 未返却
        }



        List<Category> categories = new List<Category>
        {
            new Category { Id = 1, Name = "PC周辺機器" },
            new Category { Id = 2, Name = "オーディオ" },
            new Category { Id = 3, Name = "アクセサリ" },
        };

        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "ノートパソコン", Price = 89800, Stock = 15, CategoryId = 1 },
            new Product { Id = 2, Name = "ワイヤレスマウス", Price = 2480, Stock = 120, CategoryId = 1 },
            new Product { Id = 3, Name = "メカニカルキーボード", Price = 12800, Stock = 45, CategoryId = 1 },
            new Product { Id = 4, Name = "27インチモニター", Price = 34800, Stock = 8, CategoryId = 1 },
            new Product { Id = 5, Name = "USB-Cハブ", Price = 3980, Stock = 60, CategoryId = 3 },
            new Product { Id = 6, Name = "外付けSSD 1TB", Price = 14800, Stock = 25, CategoryId = 1 },
            new Product { Id = 7, Name = "Webカメラ", Price = 5980, Stock = 3, CategoryId = 1 },
            new Product { Id = 8, Name = "ノイズキャンセリングヘッドホン", Price = 24800, Stock = 30, CategoryId = 2 },
            new Product { Id = 9, Name = "スマホスタンド", Price = 1280, Stock = 200, CategoryId = 3 },
            new Product { Id = 10, Name = "ポータブル充電器", Price = 4480, Stock = 0, CategoryId = 3 },
        };


        List<Author> authors = new List<Author>
        {
            new Author { Id = 1, Name = "夏目漱石" },
            new Author { Id = 2, Name = "芥川龍之介" },
            new Author { Id = 3, Name = "太宰治" },
        };

        List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "吾輩は猫である", AuthorId = 1, PublishedYear = 1905 },
            new Book { Id = 2, Title = "坊っちゃん", AuthorId = 1, PublishedYear = 1906 },
            new Book { Id = 3, Title = "こころ", AuthorId = 1, PublishedYear = 1914 },
            new Book { Id = 4, Title = "羅生門", AuthorId = 2, PublishedYear = 1915 },
            new Book { Id = 5, Title = "鼻", AuthorId = 2, PublishedYear = 1916 },
            new Book { Id = 6, Title = "人間失格", AuthorId = 3, PublishedYear = 1948 },
            new Book { Id = 7, Title = "走れメロス", AuthorId = 3, PublishedYear = 1940 },
            // 著者ID=99は存在しない(問題6用)
            new Book { Id = 8, Title = "謎の絶版本", AuthorId = 99, PublishedYear = 1900 },
        };


        List<Loan> loans = new List<Loan>
        {
            new Loan { Id = 1, BookId = 1, BorrowerName = "田中", LoanDate = new DateTime(2026, 6, 1), ReturnDate = new DateTime(2026, 6, 10) },
            new Loan { Id = 2, BookId = 3, BorrowerName = "佐藤", LoanDate = new DateTime(2026, 6, 5), ReturnDate = null },
            new Loan { Id = 3, BookId = 1, BorrowerName = "鈴木", LoanDate = new DateTime(2026, 6, 15), ReturnDate = new DateTime(2026, 6, 20) },
            new Loan { Id = 4, BookId = 6, BorrowerName = "田中", LoanDate = new DateTime(2026, 7, 1), ReturnDate = null },
            new Loan { Id = 5, BookId = 3, BorrowerName = "高橋", LoanDate = new DateTime(2026, 7, 3), ReturnDate = new DateTime(2026, 7, 8) },
            new Loan { Id = 6, BookId = 7, BorrowerName = "伊藤", LoanDate = new DateTime(2026, 7, 5), ReturnDate = null },
        };

        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int ClassId { get; set; }
        }

        public class ClassRoom
        {
            public int ClassId { get; set; }
            public string ClassName { get; set; }
        }

        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "田中", ClassId = 101 },
            new Student { Id = 2, Name = "鈴木", ClassId = 102 },
            new Student { Id = 3, Name = "佐藤", ClassId = 101 },
            new Student { Id = 4, Name = "高橋", ClassId = 103 },
        };

        List<ClassRoom> classRooms = new List<ClassRoom>
        {
            new ClassRoom { ClassId = 101, ClassName = "1組" },
            new ClassRoom { ClassId = 102, ClassName = "2組" },
        };



        public void printout() {
            var ps = from b in products
                     where (b.Price >= 5000)
                     orderby b.Price descending 
                      select(b.Name);

            Console.WriteLine(ps.ToArray());

            products.Where(b=>b.Price>=5000)
                .OrderByDescending(s=>s.Price).ToList().ForEach(
                    b=> Console.WriteLine($"{b.Name}  {b.Price}")
                );



            var ps2 = from b in products
                      where (b.Stock >= 50)
                      select b;

            var fiftyovercount = ps2.Count();
            var fiftyovercount2 = ps2.Sum(p=>p.Stock);


            int suma = products.Where(s => s.Stock >= 50)
                              .Sum(s => s.Stock);
            int counta = products.Where(s => s.Stock >= 50)
                                .Count();
            Console.WriteLine("---------------------------------------------------------");
            products
                .GroupBy(p => p.CategoryId)
                .Join(categories,
                      g => g.Key,
                      c => c.Id,
                      (g, c) => new
                      {
                          CategoryName = c.Name,
                          Count = g.Count(),
                          TotalStock = g.Sum(x => x.Stock)
                      }).ToList().ForEach(b => Console.WriteLine($"{b.CategoryName}{b.Count}個{b.TotalStock}円"));

            Console.WriteLine("---------------------------------------------------------");
            //joinの書き方
            books.Join(authors,
                b => b.AuthorId,
                a => a.Id,
                (b, a) => new { b.Title, AuthorName = a.Name }).ToList()
                .ForEach(b=>Console.WriteLine($" {b.Title}  {b.AuthorName}"));

            Console.WriteLine("---------------------------------------------------------");

            books.Join(authors,
                b => b.AuthorId,
                a => a.Id,
                (b, a) => new { b.Title, AuthorName = a.Name })
                .Where(b => b.AuthorName == "夏目漱石").ToList()
                .ForEach(b => Console.WriteLine($" {b.Title}  {b.AuthorName}"));
            Console.WriteLine("---------------------------------------------------------");
            //３項間join
            books.Join(authors,
                 b => b.AuthorId,
                 a => a.Id,
                 (b,a) => new {a.Name, b.Title ,b.Id, AuthorName = a.Name })
                .Join(loans,
                 b => b.Id,
                 l => l.Id,
                 (b,l) => new {b.Id ,b.Title, b.AuthorName, BorrowerName = l.BorrowerName }
                ).ToList()
                .ForEach(b => Console.WriteLine($" {b.Title}  {b.AuthorName}  {b.BorrowerName}"));
            Console.WriteLine("---------------------------------------------------------");
            books.Join(loans,
                b => b.Id,
                l => l.BookId,
             (b, l) => b.Title)
                .GroupBy(title => title)
                .Select(g => new {title = g.Key , Count = g.Count()})
                .ToList()
                .ForEach(b => Console.WriteLine($"{b.title}  {b.Count}囘"));
            Console.WriteLine("---------------------------------------------------------");

            loans.Where(l => l.ReturnDate == null)
                 .Join(books,
                 l => l.BookId,
                 b => b.Id,
                 (l, b) => new { b.Title, l.LoanDate }
                ).OrderBy(l=>l.LoanDate).
                ToList()
                .ForEach(b => Console.WriteLine($"{b.Title} {b.LoanDate}"));

            Console.WriteLine("---------------------------------------------------------");

            students.Join(classRooms,
                s => s.ClassId,
                c => c.ClassId,
                (s, c) => new {s.Name, c.ClassName}
                ).ToList().ForEach(s => Console.WriteLine($"{s.Name}  {s.ClassName}"));

            Console.WriteLine("---------------------------------------------------------");


        }
    }
}
