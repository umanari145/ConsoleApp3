using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp3.Util
{
    internal class CollectionSample8
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string ClassName { get; set; }
            public List<int> Scores { get; set; } // 各科目の点数
        }

        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "田中", Age = 20, ClassName = "A組", Scores = new List<int> { 85, 90, 78 } },
            new Student { Id = 2, Name = "佐藤", Age = 22, ClassName = "B組", Scores = new List<int> { 60, 75, 80 } },
            new Student { Id = 3, Name = "鈴木", Age = 21, ClassName = "A組", Scores = new List<int> { 95, 88, 92 } },
            new Student { Id = 4, Name = "高橋", Age = 20, ClassName = "C組", Scores = new List<int> { 55, 60, 65 } },
            new Student { Id = 5, Name = "伊藤", Age = 23, ClassName = "B組", Scores = new List<int> { 70, 70, 70 } },
        };

        public void outputter()
        {   
            students.Where(s => s.Age >= 21).ToList().ForEach(student => { Console.WriteLine(student.Name); });
            Console.WriteLine("-----------------------------------------------------------------------------");

            students.Select(s => s.Name).ToList().ForEach(student => Console.WriteLine(student));
            Console.WriteLine("-----------------------------------------------------------------------------");
            students.OrderBy(s => s.Age).ToList().ForEach(student => Console.WriteLine(student.Name + "  " + student.Age));
            Console.WriteLine("-----------------------------------------------------------------------------");
            students.OrderByDescending(s => s.ClassName).ThenBy(s => s.Name).ToList().ForEach((s) => Console.WriteLine($"{s.Name} {s.ClassName}"));
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.Write(students.Any());
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine(students.All(s => s.Age >= 20));
            Console.WriteLine("-----------------------------------------------------------------------------");
            var groups = students.GroupBy(s => s.ClassName);
            foreach(var group in groups)
            {
                Console.WriteLine(group.Key);
                foreach(var g in group)
                {
                    Console.WriteLine(g.Name);
                }
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
            students.GroupBy(s => s.ClassName)
                     .Select(g => new { ClassName = g.Key, Count = g.Count() })
                     .ToList().ForEach(g => Console.WriteLine(g.ClassName + " " + g.Count));
            Console.WriteLine("-----------------------------------------------------------------------------");
            students.ForEach(s =>
               Console.WriteLine(s.Name + " " + s.Scores.Average())
            );
            Console.WriteLine("-----------------------------------------------------------------------------");
            students.Select(s => new { s.Name, Average = s.Scores.Average() })
                .ToList().ForEach(s => Console.WriteLine(s.Name + " " + s.Average)
            );
            Console.WriteLine(students.Select(s => new { s.Name, Average = s.Scores.Average() })
                .MaxBy(s => s.Average).ToString());
                


        }
    }
}
