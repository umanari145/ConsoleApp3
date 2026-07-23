using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Util
{
    internal class enumlesson
    {
        enum Weekday
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        enum HttpStatusCode
        {
            OK = 200,
            NotFound = 404,
            InternalServerError = 500
        }

        enum Season { Spring, Summer, Autumn, Winter }

        static string GetSeasonMessage(Season season) => season switch
        {
            Season.Spring => "花が咲く季節です",
            Season.Summer => "暑い季節です",
            Season.Autumn => "紅葉の季節です",
            Season.Winter => "雪が降る季節です",
            _ => "不明な季節です"
        };

        public void output()
        {
            Console.WriteLine(Weekday.Friday);
            Console.WriteLine((int)HttpStatusCode.NotFound);
            Console.WriteLine(Season.Spring);
            Console.WriteLine(GetSeasonMessage(Season.Autumn));
        }


    }
}
