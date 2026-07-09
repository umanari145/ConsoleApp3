using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp3.Util
{
    internal class RegexSample
    {

        public void judgemenet()
        {
            string pattern = @"^\d{3}-\d{4}$";

            string[] inputs = { "123-4567", "1234567", "12-34567", "abc-defg" };

            foreach (var input in inputs)
            {
                bool isValid = Regex.IsMatch(input, pattern);
                Console.WriteLine($"{input} : {(isValid ? "有効な郵便番号" : "無効")}");
            }
        }

        public void filtering()
        {
            string pattern = @"\d{3}-\d{4}";

            string text = "住所は123-4567東京都中央句です。";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match m in matches)
            {
                //valueは抽出文字、indexは抽出文字の位置
                Console.WriteLine($" 抽出結果{m.Value}  位置: {m.Index}");
            }
        }

        public void replace()
        {
            string text = "旧郵便番号1234567を新形式に変換します。";
            string pattern = @"(\d{3})(\d{4})";
            string replacement = "$1-$2";

            string result = Regex.Replace(text, pattern, replacement);
            Console.WriteLine(result);
        }
    }
}
