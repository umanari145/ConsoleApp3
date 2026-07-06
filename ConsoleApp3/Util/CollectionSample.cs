using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using ConsoleApp3.Entity;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp3.Util
{
    internal class CollectionSample
    {

        public void collectionSample()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "ノートPC",   Category = "電化製品", Price = 89800, Stock = 5  },
                new Product { Id = 2, Name = "マウス",     Category = "電化製品", Price = 1980,  Stock = 30 },
                new Product { Id = 3, Name = "コーヒー豆", Category = "食品",     Price = 1200,  Stock = 0  },
                new Product { Id = 4, Name = "ノート",     Category = "文房具",   Price = 150,   Stock = 100},
                new Product { Id = 5, Name = "モニター",   Category = "電化製品", Price = 24800, Stock = 8  },
                new Product { Id = 6, Name = "紅茶",       Category = "食品",     Price = 800,   Stock = 15 },
                new Product { Id = 7, Name = "ボールペン", Category = "文房具",   Price = 100,   Stock = 0  },
                new Product { Id = 8, Name = "キーボード", Category = "電化製品", Price = 6980,  Stock = 12 },
            };

            /*Q1.基本のWhere
            在庫が0個（在庫切れ）の商品だけを抽出してください。
            Q2.Select（射影）
            全商品の「商品名」だけをリストとして取得してください（List<string>）。
            Q3.OrderBy
            価格が高い順に商品を並び替えて、上位3件を取得してください。
            Q4.集計（Sum / Average）
            全商品の在庫金額（価格×在庫数の合計）を求めてください。
            Q5.GroupBy
            カテゴリごとに商品をグループ化し、「カテゴリ名」と「そのカテゴリの商品数」を表示してください。
            Q6.複合条件
            「電化製品」カテゴリで、かつ在庫が10個以上ある商品を、価格が安い順に取得してください。
            Q7.Any / All
            「文房具」カテゴリに、在庫切れの商品が1つでもあるかどうかを判定してください（bool を返す）。
            Q8.応用：カテゴリ別の在庫金額ランキング
            カテゴリごとの在庫金額合計を求め、金額が高い順に並べて表示してください。
            出力イメージ：
            電化製品: ¥1,047,400
            食品: ¥12,000
            文房具: ¥15,000
            Q9.ToDictionary
            「商品ID」をキー、「商品名」を値とする Dictionary<int, string> を作成してください。
            Q10.Min / Max + 該当商品
            全商品の中で最も価格が高い商品（Product 1件）を取得してください。（OrderByを使わない方法で）
            */


            //Q1
            Console.WriteLine($"---------Q1------------------");
            products.Where(e => e.Stock == 0).ToList().ForEach(e =>
            {
                Console.WriteLine($"在庫がない商品: id:{e.Id} Name {e.Name} Category {e.Category} Price {e.Price} Stock {e.Stock}  ");
            });
            //Q2
            Console.WriteLine($"---------Q2------------------");
            products.Select(e => e.Name).ToList().ForEach(e =>
            {
                Console.WriteLine($"商品名: {e}");
            });
            //Q3
            Console.WriteLine($"---------Q3------------------");
            products.OrderByDescending(e => e.Price).Take(3).ToList().ForEach(e =>
            {
                Console.WriteLine($"商品名: {e.Name} 価格: {e.Price}");
            });
            //Q4
            Console.WriteLine($"---------Q4------------------");
            int totalPrice = products.Sum(e => e.Price * e.Stock);
             Console.WriteLine($"全商品の合計金額: {totalPrice}");
            //Q5
            Console.WriteLine($"---------Q5------------------");
            products.GroupBy(e =>e.Category).ToList().ForEach(g =>
            {
                int totalCountByCategory = g.Count();
                Console.WriteLine($"カテゴリ: {g.Key}, 数量: {totalCountByCategory}");
            });
            //Q6
            Console.WriteLine($"---------Q6------------------");
            products.Where(e => e.Category == "電化製品" && e.Stock >=10).
                 OrderBy(g =>g.Price ).ToList().ForEach(g =>
                 Console.WriteLine(g.Name)
           );
            //Q7
            Console.WriteLine($"---------Q7------------------");
            bool result = products.Where(e=>e.Category == "文房具"　&& e.Stock <=0 ).ToList().Count() > 0;
            Console.WriteLine($"-{result}");
            //Q8
            Console.WriteLine($"---------Q8------------------");
            products.GroupBy(e => e.Category)
                 .Select(g => new
                 {
                     category = g.Key,
                     total = g.Sum(e => e.Price * e.Stock)
                 }).OrderByDescending(g => g.total).ToList().ForEach(g =>
                 {
                     Console.WriteLine($"カテゴリ: {g.category}, 金額: {g.total}");
                 });

            //Q9
            Console.WriteLine($"---------Q9------------------");
            products.ToDictionary(p => p.Id, p => p.Name).ToList().ForEach(kv =>
            {
                Console.WriteLine($"Id: {kv.Key}, Name: {kv.Value}");
            });
            //Q10
            Console.WriteLine($"---------Q10------------------");
            Product? maxproduct = products.MaxBy(e => e.Price);
            if (maxproduct != null)
            {
                Console.WriteLine($"最も高い商品: Id: {maxproduct.Id}, Name: {maxproduct.Name}, Price: {maxproduct.Price}");
            }

        }


        public void dateSample()
        {
            //基礎編
            //問題1：曜日の判定
            //今日の日付を取得し、それが土曜日か日曜日かを判定して「平日です」または「休日です」と表示するプログラムを書いてください。
            //問題2：日数の差分
            //2つの日付（例：2026年1月1日と2026年7月6日）を受け取り、その間の日数を計算して表示してください

            Console.WriteLine("$---------Q1------------------");
            DateTime dt = DateTime.Now;
            if (dt.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("今日は日曜日です。");
            }
            else if (dt.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("今日は土曜日です。");
            }
            else
            {
                Console.WriteLine("今日は平日です。");
            }
            Console.WriteLine("$---------Q2------------------");
            DateTime dt2 = new DateTime(2026, 1, 1);
            DateTime dt3 = new DateTime(2026, 7, 6);
            var diff = dt3.Subtract(dt2);
            Console.WriteLine(diff);
            Console.WriteLine("$---------Q3------------------");
            DateTime dt4 =  DateTime.Now;

            // その月末の日時を取得する
            DateTime today = DateTime.Today;
            DateTime endOfMonth = new DateTime(today.Year, today.Month, 1)
                .AddMonths(1)
                .AddDays(-1);
            Console.WriteLine($"今月の末日: {endOfMonth:yyyy年M月d日}");
            // こういう書き方もできる
            int lastDay = DateTime.DaysInMonth(today.Year, today.Month);
            //先月の月初と月末を取得する
            DateTime startOfLastMonth = new DateTime(today.Year, today.Month, 1).AddMonths(-1);
            DateTime endOfLastMonth = startOfLastMonth.AddMonths(1).AddDays(-1);
            Console.WriteLine($"先月: {startOfLastMonth:yyyy年M月d日} 〜 {endOfLastMonth:yyyy年M月d日}");
            //先週の月曜日と日曜日を取得する
            int diff2 = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
            DateTime startOfThisWeek = today.AddDays(-diff2);
            DateTime startOfLastWeek = startOfThisWeek.AddDays(-7);
            DateTime endOfLastWeek = startOfLastWeek.AddDays(6);
            Console.WriteLine($"先週: {startOfLastWeek:yyyy年M月d日} 〜 {endOfLastWeek:yyyy年M月d日}");
            //任意のフォーマットの出力
            DateTime dt5 = DateTime.Now;
            Console.WriteLine(dt5.ToString("yyyy年MM月dd日 HH時mm分ss秒"));
            Console.WriteLine(dt5.ToString("yyyy/MM/dd HH:mm:ss"));
            Console.WriteLine(dt5.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(dt5.ToString("yyyy"));
            //加算・減算
            DateTime dt6 = DateTime.Now;
            Console.WriteLine(dt6.AddMonths(1).ToString("yyyy/MM/dd HH:mm:ss"));
            DateTime dt7 = DateTime.Now;
            Console.WriteLine(dt7.AddHours(1).ToString("yyyy/MM/dd HH:mm:ss"));
            Console.WriteLine(dt7.AddDays(7).ToString("yyyy/MM/dd HH:mm:ss"));
        }
    }
}
