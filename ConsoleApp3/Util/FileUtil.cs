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
    }
}
