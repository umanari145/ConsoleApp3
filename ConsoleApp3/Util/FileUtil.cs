using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Text;
using ConsoleApp3.Entity;
using CsvHelper;

namespace ConsoleApp3.Util
{
    internal class FileUtil
    {
        public void fileGetContents()
        {
            var filePath = @"C:\Users\matsumoto\source\repos\ConsoleApp3\sample.csv";

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"エラー: ファイルが見つかりません: {filePath}");
                return;
            }

            var records = new List<SalesRecord>();
            int skipCount = 0;

            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            csv.Read();
            csv.ReadHeader();

            while (csv.Read())
            {
                try
                {
                    var record = new SalesRecord
                    {
                        SaleDate = csv.GetField<DateTime>("SaleDate"),
                        StoreCode = csv.GetField("StoreCode") ?? "",
                        ProductCode = csv.GetField("ProductCode") ?? "",
                        ProductName = csv.GetField("ProductName") ?? "",
                        Category = csv.GetField("Category") ?? "",
                        Quantity = csv.GetField<int>("Quantity"),
                        UnitPrice = csv.GetField<decimal>("UnitPrice")
                    };
                    records.Add(record);
                }
                catch (Exception)
                {
                    // 数値変換エラーなどはスキップしてカウント
                    skipCount++;
                }
            }

            Console.WriteLine($"読み込み件数: {records.Count}件");
            Console.WriteLine($"スキップ件数: {skipCount}件");

            var SalesBystoreCode = records.GroupBy(e => e.StoreCode);

            foreach (var s in SalesBystoreCode)
            {
                decimal totalAmount = s.Sum(e => e.Quantity * e.UnitPrice);
                Console.WriteLine($"店舗コード: {s.Key}, 売上合計: {totalAmount:C}");
            }

        }


        public void UserInfo()
        {
            List<Dictionary<string, string>> lc = new List<Dictionary<string, string>>();

            // 一番プレーンな書き方
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("name", "kazuki");
            dic.Add("domain", "gmail");
            dic.Add("age", "30");
            dic.Add("pref", "chiba");
            dic.Add("math", "67");
            dic.Add("english", "87");
            lc.Add(dic);


            Dictionary<string, string> dic2 = new Dictionary<string, string>()
            {
                { "name", "ichirou" },
                { "domain", "yahoo.co.jp" },
                { "age", "15" },
                { "pref", "tokyo" },
                { "math", "55" },
                { "english", "12" },
            };
            lc.Add(dic2);

            // 初期化子を使った書き方
            var dic3 = new Dictionary<string, string>()
            {
                { "name", "yuusuke" },
                { "domain", "hotmail.com" },
                { "age", "23" },
                { "pref", "chiba" },
                { "math", "67" },
                { "english", "75" },
            };
            lc.Add(dic3);

            var dic4 = new Dictionary<string, string>()
            {
                { "name", "satoshi" },
                { "domain", "gmail.com" },
                { "age", "45" },
                { "pref", "kanagawa" },
                { "math", "23" },
                { "english", "47" },
            };
            lc.Add(dic4);


            var dic5 = new Dictionary<string, string>()
            {
                { "name", "jirou" },
                { "domain", "hotmail.com" },
                { "age", "9" },
                { "pref", "tokyo" },
                { "math", "45" },
                { "english", "9" },
            };

            lc.Add(dic5);


            foreach (var d in lc)
            {
                Console.WriteLine($"名前: {d["name"]}, ドメイン: {d["domain"]}, 年齢: {d["age"]}, 都道府県: {d["pref"]}, 数学: {d["math"]}, 英語: {d["english"]}");
            }


            var grouping = lc.GroupBy(e => e["pref"]);
            foreach (var eachDic in grouping.OrderBy(g => int.Parse(g.First()["age"])))
            {
                Console.WriteLine($"都道府県: {eachDic.Key}");
                foreach (var d in eachDic)
                {
                    d["email"] = $"{d["name"]}@{d["domain"]}";
                    Console.WriteLine(d);
                }

            }

        }

        public void getProductInfo()
        {
            var filePath = @"C:\Users\matsumoto\source\repos\ConsoleApp3\product.csv";

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"エラー: ファイルが見つかりません: {filePath}");
                return;
            }

            var records = new List<Product>();
            int skipCount = 0;

            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            csv.Read();
            csv.ReadHeader();
            int lineLoop = 0;
            while (csv.Read())
            {
                lineLoop++;
                try
                {
                    var record = new Product
                    {
                        Id = csv.GetField<int>("Id"),
                        Name = csv.GetField("Name") ?? "",
                        Category = csv.GetField("Category") ?? "",
                        Price = csv.GetField<int>("Price"),
                        Stock = csv.GetField<int>("Stock"),
                    };
                    records.Add(record);
                    
                }
                catch (Exception)
                {
                    Console.WriteLine($"スキップ: {lineLoop}行目");
                }
            }

            foreach (var record2 in records)
            {
                if (record2.Stock <= 0)
                {
                    Console.WriteLine($"在庫がない商品: id:{record2.Id} Name {record2.Name} Category {record2.Category} Price {record2.Price} Stock {record2.Stock}  ");
                } else
                {
                    Console.WriteLine($"id:{record2.Id} Name {record2.Name} Category {record2.Category} Price {record2.Price} Stock {record2.Stock}  ");
                }
            }
            
            
            int allTotalPrice = records.Sum(e => e.Price * e.Stock);
            Console.WriteLine($"全商品の合計金額: {allTotalPrice}");

            records.GroupBy(e => e.Category).ToList().ForEach(g =>
            {
                int totalPrice = g.Sum(e => e.Price * e.Stock);
                Console.WriteLine($"カテゴリ: {g.Key}, 合計金額: {totalPrice}");
            });

            //商品の追加
            records.Where(e => e.Id == 5).ToList().ForEach(e =>
            {
                e.Stock +=1;
                Console.WriteLine($"商品の追加後の在庫数: {e.Id} 名前 {e.Name} 在庫数 {e.Stock}");
            });


            try
            {
                var singleRecord = records.First(e => e.Id == 7);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("存在しない商品です。");
            }


            //商品の追加
            try
            {

                //商品の削除
                records.Where(e => e.Id == 3).ToList().ForEach(e =>
                {
                    if (e.Stock <= 0)
                    {
                        throw new InsufficientStockException("在庫が不足しています");
                    }
                    e.Stock -= 1;
                    Console.WriteLine($"商品の削除後の在庫数: {e.Id} 名前 {e.Name} 在庫数 {e.Stock}");
                });
            }
            catch (InsufficientStockException ex)
            {
                Console.WriteLine("在庫が不足しています。");
            }

        }
    }
}
