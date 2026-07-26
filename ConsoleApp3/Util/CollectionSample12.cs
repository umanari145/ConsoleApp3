using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;


namespace ConsoleApp3.Util
{
    internal class CollectionSample12
    {
        public class Student
        {
            public string Name { get; set; }
            public string Class { get; set; }   // クラス名 (例: "A", "B", "C")
            public int Score { get; set; }      // テストの点数
            public string Subject { get; set; } // 科目
        }

        List<Student> students = new List<Student>
        {
            new Student { Name = "田中", Class = "A", Score = 85, Subject = "数学" },
            new Student { Name = "佐藤", Class = "A", Score = 70, Subject = "数学" },
            new Student { Name = "鈴木", Class = "B", Score = 90, Subject = "数学" },
            new Student { Name = "高橋", Class = "B", Score = 60, Subject = "英語" },
            new Student { Name = "伊藤", Class = "A", Score = 95, Subject = "英語" },
            new Student { Name = "渡辺", Class = "C", Score = 75, Subject = "英語" },
            new Student { Name = "山本", Class = "C", Score = 80, Subject = "数学" },
            new Student { Name = "中村", Class = "B", Score = 55, Subject = "数学" },
        };

        public void output()
        {
            var grouped = students.GroupBy(s => s.Class)
                .Select(g=> new
                {
                    Name = g,
                    Class = g.Key,
                    count = g.Count(),
                    Average = g.Average(s=>s.Score),
                    Max = g.Max(s=>s.Score),
                    Min = g.Min(s=>s.Score),
                });

            foreach (var group in grouped)
            {
                Console.WriteLine(group.Class);
                Console.WriteLine(group.count);
                Console.WriteLine(group.Average);
                Console.WriteLine(group.Max);
                Console.WriteLine(group.Min);
                foreach (var g in group.Name)
                {
                    Console.WriteLine(g.Name);
                }
            }

            Console.WriteLine("------------------------------------");
            var groupe2 = students.GroupBy(s => s.Subject)
                .Select(g => new
                {
                    Name = g,
                    Class = g.Key,
                    sum = g.Sum(s=>s.Score),
                });

            foreach (var group2 in groupe2) {
                Console.WriteLine(group2.sum);                
            }
        }        
    }
}
