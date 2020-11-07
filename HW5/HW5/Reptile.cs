using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;


namespace HW5 {
    class Reptile {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        private int deepth = 0;
        private string filePath = "";
        private string startUrl;

        public Reptile(string startUrl, string filePath, int deepth = 10) {
            this.startUrl = startUrl;
            this.urls.Add(this.startUrl, false);
            this.deepth = deepth;
            this.filePath = filePath;
        }

        public void Start() {
            new Thread(this.Crawl).Start();
        }

        private void Crawl() {
            while (true) {
                string current = null;
                foreach(string url in urls.Keys) {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > deepth) {
                    break;
                }

                Console.WriteLine(current);

                string html = Download(current);

                urls[current] = true;
                count++;

                Parse(html);
            }
        }

        private string currentPage(string Page) {
            return Page;
        }

        public string Download(string url) {
            try {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);

                string fileName = filePath + count.ToString() + ".html";
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public void Parse(string html) {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+(.html|.htm|.jsp|.aspx|.php)[""']";
            string httpRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+(.com)[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            MatchCollection httpMatches = new Regex(httpRef).Matches(html);

            foreach(Match match in httpMatches) {
                strRef = match.Value.Substring(match.Value.IndexOf("=") + 1).Trim('"', '\"', '#', ' ', '>');
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }

            foreach (Match match in matches) {
                //Console.WriteLine(match);
                strRef = match.Value.Substring(match.Value.IndexOf("=") + 1).Trim('"', '\"', '#', ' ', '>');
                string httpParse = @"(http|https)";
                string wwwParse = @"(www)";
                if (!Regex.IsMatch(strRef, httpParse)) {
                    //Console.WriteLine(strRef);
                    if (strRef[0] == '/') {
                        strRef = startUrl + strRef;
                    }
                    else if (Regex.IsMatch(strRef, wwwParse)) {
                        strRef = "http://" + strRef;
                    }
                    else {
                        strRef = startUrl + "/" + strRef;
                    }
                }
                //Console.WriteLine(strRef);

                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
    }
}
