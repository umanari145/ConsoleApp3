using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;


namespace ConsoleApp3.Util
{
    internal class CollectionSample10
    {
        public class member
        {
            public string name { set; get; }
            public int age { set; get; }
            public string domain { set; get; }
            public string pref { set; get; }
        }

        List<member> members = new List<member>
        {
            new member{name="kazumi", age=30,domain="yahoo.co.jp",pref="chiba"},
            new member{name="ichiro", age=12,domain="gmail.com",  pref="tokyo"},
            new member{name="airi",   age=32,domain="hotmail.com",pref="kanagawa"},
            new member{name="aina",   age=25,domain="gmail.com",pref="kanagawa"},
            new member{name="kazumi", age=30,domain="yahoo.co.jp",pref="chiba"}
        };

        public void output()
        {
            members.Where(m => m.age >= 20).ToList().ForEach(m => Console.WriteLine($"{m.name}  {m.age}"));
            Console.WriteLine("-------------------------------------------------------------");
            members.Select(m=>m.domain).ToList().ForEach(m => Console.WriteLine($"{m}"));
            Console.WriteLine("-------------------------------------------------------------");
            var groups = members.GroupBy(m => m.age >= 20);
            foreach(var group in groups)
            {
                Console.WriteLine(group.Key ? "20才以上" : "20才以下");
            　　foreach(var m in group)
                {
                    Console.WriteLine($" {m.name}   {m.age}  ");
                }
            }
            Console.WriteLine("-------------------------------------------------------------");
            members.Select(m=> m.name +"@"+m.domain).ToList().ForEach(m => Console.WriteLine($"{m}"));
            Console.WriteLine("-------------------------------------------------------------");
            members.Where(m=>m.age >=30).
                Select(m =>m.name + "@" + m.domain).ToList().ForEach(m => Console.WriteLine($"{m}"));
        }
    }
}
