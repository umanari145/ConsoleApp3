using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Util
{
    internal class StringUtil
    {


        public void output()
        {
            string firstName = "太郎";
            string lastName = "山田";

            // + 演算子
            string fullName1 = lastName + firstName;

            // string.Concat
            string fullName2 = string.Concat(lastName, firstName);

            // 文字列補間(推奨)
            string fullName3 = $"{lastName}{firstName}";

            Console.WriteLine(fullName3); // 山田太郎


            int age = 25;
            double price = 1234.5;

            // 基本形
            string message = $"年齢は{age}歳です";

            // 書式指定(数値を3桁カンマ区切り、小数点2桁)
            string formatted = $"価格は{price:N2}円です"; // 価格は1,234.50円です

            // 式や計算式も埋め込める
            string calc = $"来年は{age + 1}歳になります";

            // 改行を含む複数行文字列(C# 11以降: raw string literal)
            string raw = $"""
                        名前: {firstName}
                        年齢: {age}
                        """;

            decimal price2 = 1234567.891m;
            DateTime date = new DateTime(2026, 7, 23);

            // 数値フォーマット
            Console.WriteLine($"{price2:N2}");   // 1,234,567.89
            Console.WriteLine($"{price2:C}");    // ¥1,234,568 (通貨)
            Console.WriteLine($"{price2:0.00}"); // 1234567.89

            // 日付フォーマット
            Console.WriteLine($"{date:yyyy年MM月dd日}"); // 2026年07月23日
            Console.WriteLine($"{date:yyyy-MM-dd}");      // 2026-07-23

            // パディング(桁揃え)
            int num = 5;
            Console.WriteLine($"{num:D3}"); // 005
        }
    }
}
