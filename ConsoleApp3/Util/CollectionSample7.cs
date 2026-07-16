using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Util
{
    internal class CollectionSample7
    {
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

        public class Score
        {
            public int StudentId { get; set; }
            public string Subject { get; set; }
            public int Point { get; set; }
        }

        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "田中", ClassId = 101 },
            new Student { Id = 2, Name = "鈴木", ClassId = 102 },
            new Student { Id = 3, Name = "佐藤", ClassId = 101 },
            new Student { Id = 4, Name = "高橋", ClassId = 102 },
        };

        List<ClassRoom> classRooms = new List<ClassRoom>
        {
            new ClassRoom { ClassId = 101, ClassName = "1組" },
            new ClassRoom { ClassId = 102, ClassName = "2組" },
        };

        List<Score> scores = new List<Score>
        {
            new Score { StudentId = 1, Subject = "数学", Point = 80 },
            new Score { StudentId = 1, Subject = "英語", Point = 70 },
            new Score { StudentId = 2, Subject = "数学", Point = 90 },
            new Score { StudentId = 2, Subject = "英語", Point = 60 },
            new Score { StudentId = 3, Subject = "数学", Point = 75 },
            new Score { StudentId = 3, Subject = "英語", Point = 85 },
            new Score { StudentId = 4, Subject = "数学", Point = 50 },
            new Score { StudentId = 4, Subject = "英語", Point = 95 },
        };

        
        public void output()
        {
            students.Join(classRooms,
                s => s.ClassId,
                c => c.ClassId,
                (s, c) => new { s.Id, s.Name, c.ClassId, c.ClassName }
                ).Join(scores,
                s => s.Id,
                score => score.StudentId,
                (s, score) => new { s.Name, s.ClassName, score.Point }
                ).GroupBy(s => s.Name)
                .Select(s => new
                {
                    Name = s.Key,
                    Point = s.Sum(s => s.Point)
                }).ToList().ForEach(s => Console.WriteLine($" {s.Name} - {s.Point} "));
        }

    }
}
