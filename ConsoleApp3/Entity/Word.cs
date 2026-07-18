using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using CsvHelper.Configuration.Attributes;

namespace ConsoleApp3.Entity
{
    internal class Word
    {
        public  List<string> tags { set; get; }       

        public string author  { get; set; }

        public string quote { set; get; }
    }
}
