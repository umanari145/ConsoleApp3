using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Numerics;
using System.Text;

namespace ConsoleApp3.Util
{
    internal class CollectionSample5
    {
        public class SalesRecord
        {
            public DateTime SaleDate { get; set; }
            public string StoreCode { get; set; } = "";
            public string ProductCode { get; set; } = "";
            public string ProductName { get; set; } = "";
            public string Category { get; set; } = "";
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
        }




        public void output()
        {
            var numbers = Enumerable.Range(1, 20).ToList();
            numbers.Where(x => x %2 == 0).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("---------------------------------------------------------");
            var items = new List<string> { "りんご", "みかん", "りんご", "バナナ", "みかん", "ぶどう" };
            var uniqueByHashSet = new HashSet<string>(items);
            uniqueByHashSet.ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("---------------------------------------------------------");
            string text = "apple banana apple orange banana apple";
            string[] aaa = text.Split(" ");
            var wordCount = new Dictionary<string, int>();
            foreach (var x in aaa) {
                if (wordCount.ContainsKey(x)) {
                    wordCount[x]++;
                } 
                else
                {
                    wordCount[x] = 1;
                }

            }
            Console.WriteLine("---------------------------------------------------------");
            int[] numbers2 = { 5, 12, 8, 3, 20 };
            int totalSum = 0;
            foreach (var x in numbers2)
            {
                totalSum += x; 
            }
            Console.WriteLine(totalSum);
            Console.WriteLine("---------------------------------------------------------");
            List<string> aab = new List<string> { "りんご", "ぶどう", "バナナ" };
            foreach (var fruit in aab)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine("---------------------------------------------------------");
            var scores = new List<int> { 65, 90, 72, 88, 59 };
            Console.WriteLine(scores.Max());
            Console.WriteLine(scores.Min());
            Console.WriteLine("---------------------------------------------------------");
            var scores2 = new List<int> { 65, 90, 72, 88, 59, 100, 45 };
            scores2.Where(s=> s >=70).ToList().ForEach(s => Console.WriteLine(s));
            Console.WriteLine("---------------------------------------------------------");
            Dictionary<string, int> members = new Dictionary<string, int>();
            members.Add("太郎", 25);
            members.Add("花子", 30);
            members.Add("次郎", 22);
            Console.WriteLine(members["太郎"]);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(members.ContainsKey("花子"));
            Console.WriteLine("---------------------------------------------------------");
            foreach (var member in members)
            {
                Console.WriteLine(member.Key +"さんは" + member.Value + "才です。");
            }
            Console.WriteLine("---------------------------------------------------------");
            var foods = new List<string> { "カレー", "寿司", "カレー", "ラーメン", "寿司", "カレー" };
            Dictionary<string, int> favorite = new Dictionary<string, int>();
            foreach (var food in foods) {
                if (favorite.ContainsKey(food))
                {
                    favorite[food]++;
                } 
                else
                {
                    favorite[food] = 1;
                }
            }
            foreach (var food in favorite)
            { 
                Console.WriteLine($"{food.Key} - {food.Value}");
            }


            var stock = new Dictionary<string, int>
            {
                 { "りんご", 10 },
                 { "みかん", 5 }
            };
        }
    }
}
