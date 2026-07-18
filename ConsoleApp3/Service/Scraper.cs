using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using ConsoleApp3.Entity;
using ConsoleApp3.Util;
using HtmlAgilityPack;

namespace ConsoleApp3.Service
{
    internal class Scraper
    {
        public async Task<List<Word>> getWord()
        {
            HttpUtil hutil = new HttpUtil();
            string html = await hutil.getHTML("https://quotes.toscrape.com/");

            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            var nodes = doc.DocumentNode.SelectNodes("//div[@class='quote']");
            
            List<Word> words = new List<Word>();
            
            
            foreach (var node in nodes)
            {
                Word word = new Word();
                var innertHTML = node.InnerText;
                word.quote = innertHTML;
                var nsingle = node.SelectSingleNode(".//small[@class='author']");
                var author = nsingle.InnerText;
                word.author = author;
                var ns = node.SelectNodes(".//a[@class='tag']");

                List<string> tmpList = new List<string>();
                foreach (var n in ns)
                {
                    if (n != null)
                    {
                        tmpList.Add(n.InnerText);
                    }
                }
                word.tags = tmpList;
                words.Add(word);
            }
            return words;
        }
    }
}
