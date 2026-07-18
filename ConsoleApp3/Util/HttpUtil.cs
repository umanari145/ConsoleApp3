using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Util
{
    internal class HttpUtil
    {
        public async Task<string> getHTML(string url)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36");

            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string html = await response.Content.ReadAsStringAsync();

            return html;
        }
    }
}
