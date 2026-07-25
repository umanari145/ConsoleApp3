using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using ConsoleApp3.Entity;

namespace ConsoleApp3
{
    internal class Guitar:Entity.Instrument,ITuneable
    {
        public int StringCount { get; set; }

        public Guitar(string Name, int Price, int stringCount) :base (Name ,Price)
        {
            StringCount = stringCount;
        }

        public override void Play()
        {
            Console.WriteLine("ジャーン、ギターをかき鳴らします。");
        }

        public void ITune()
        {
            Console.WriteLine("チューナーで弦を合わせます。");
        }

    }
}
