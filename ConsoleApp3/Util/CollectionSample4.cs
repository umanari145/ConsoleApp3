using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Util
{
    internal class CollectionSample4
    {
        public class Order
        {
            public int Id { get; set; }
            public string CustomerName { get; set; }
            public string ItemName { get; set; }
            public string Category { get; set; }   // "ドリンク" or "フード"
            public int Price { get; set; }
            public int Quantity { get; set; }
            public DateTime OrderedAt { get; set; }
        }

        List<Order> orders = new List<Order>
        {
            new Order { Id = 1, CustomerName = "田中", ItemName = "カフェラテ", Category = "ドリンク", Price = 480, Quantity = 1, OrderedAt = new DateTime(2026, 7, 1, 9, 15, 0) },
            new Order { Id = 2, CustomerName = "佐藤", ItemName = "クロワッサン", Category = "フード", Price = 320, Quantity = 2, OrderedAt = new DateTime(2026, 7, 1, 9, 20, 0) },
            new Order { Id = 3, CustomerName = "田中", ItemName = "アイスコーヒー", Category = "ドリンク", Price = 380, Quantity = 1, OrderedAt = new DateTime(2026, 7, 1, 11, 0, 0) },
            new Order { Id = 4, CustomerName = "鈴木", ItemName = "サンドイッチ", Category = "フード", Price = 580, Quantity = 1, OrderedAt = new DateTime(2026, 7, 1, 12, 30, 0) },
            new Order { Id = 5, CustomerName = "高橋", ItemName = "カフェラテ", Category = "ドリンク", Price = 480, Quantity = 2, OrderedAt = new DateTime(2026, 7, 2, 8, 45, 0) },
            new Order { Id = 6, CustomerName = "佐藤", ItemName = "抹茶ラテ", Category = "ドリンク", Price = 520, Quantity = 1, OrderedAt = new DateTime(2026, 7, 2, 10, 10, 0) },
            new Order { Id = 7, CustomerName = "田中", ItemName = "チーズケーキ", Category = "フード", Price = 450, Quantity = 1, OrderedAt = new DateTime(2026, 7, 2, 14, 0, 0) },
            new Order { Id = 8, CustomerName = "伊藤", ItemName = "アイスコーヒー", Category = "ドリンク", Price = 380, Quantity = 3, OrderedAt = new DateTime(2026, 7, 2, 15, 20, 0) },
        };

        public void output()
        {
            orders.Where(o=>o.Price >=400 && o.Category == "ドリンク")
                .ToList().ForEach(o => Console.WriteLine($" {o.CustomerName} {o.ItemName}"));
            Console.WriteLine("---------------------------------------------------------");
            orders.Select(o => new { o.ItemName, subtotal = o.Price * o.Quantity }) 
                .ToList().ForEach(o => Console.WriteLine($"{o.ItemName} {o.subtotal}"));
            Console.WriteLine("---------------------------------------------------------");
            orders.OrderByDescending(o=>o.OrderedAt.Date)
                .ThenByDescending(o => o.Price)
                .ToList()
                .ForEach(o => Console.WriteLine($" {o.Id}  {o.OrderedAt} {o.Price}"));
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("田中さんの注文件数" + orders.Where(o => o.CustomerName == "田中").Count());
            Console.WriteLine("---------------------------------------------------------");
            orders.GroupBy(o => o.Category)
                  .Select(g => new { Category = g.Key, total = g.Sum(o => o.Price * o.Quantity) })
                  .ToList()
                  .ForEach(g => Console.WriteLine($" {g.Category} での合計{g.total}"));
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(orders.OrderByDescending(o => o.OrderedAt)
                .FirstOrDefault().ToString());
            Console.WriteLine("---------------------------------------------------------");
            orders.OrderByDescending(o => o.OrderedAt)
                .Take(3).ToList().ForEach(o => Console.WriteLine($" {o.CustomerName}  {o.OrderedAt}"));
            Console.WriteLine("---------------------------------------------------------");
            orders.GroupBy(o => o.CustomerName)
                .Select(g => new { CustomerName = g.Key, totalPrice = g.Sum(o => o.Price * o.Quantity)})
                .ToList()
                .ForEach (g => Console.WriteLine($"{g.CustomerName} {g.totalPrice}"));

        }
    }
}
