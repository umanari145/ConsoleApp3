using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Text;

namespace ConsoleApp3.Entity
{
    internal class Book
    {
        private string title;

        private string author;

        private int price;

        public Book(string title, string author, int price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public void messsage()
        {
            Console.WriteLine($" {this.title}の著者は{this.author}で{this.price}です。");
        }
    }
}
