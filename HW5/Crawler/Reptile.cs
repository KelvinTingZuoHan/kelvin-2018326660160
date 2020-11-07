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
using System.Windows.Forms;


namespace REPTILE {
    class MyCrawler {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        private int deepth = 0;
        private string filePath = "";
        private string startUrl;
        private string currentURL = "";

        public MyCrawler(string startUrl, string filePath, int deepth = 10) {
            this.startUrl = startUrl;
            urls.Add(this.startUrl, false);
            this.deepth = deepth;
            this.filePath = filePath;
        }

        public void Start(Form1 form) {
            new Thread(() => this.Crawl(form)).Start();
        }

        public void renewWindowURL(Form1 form) {
            renewUrlList renewUrl = form.renewUrlList;
            renewUrl(this.currentURL);
        }


        private void Crawl(Form1 form) {
            
            while (true) {
                string current = null;
                foreach(string url in urls.Keys) {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > deepth) {
                    break;
                }

                currentURL = current;
                form.Invoke((MethodInvoker)(() => form.renewUrlList("Extracting: " + current)));
                //new Thread(() => this.Download(current, form)).Start();
                Download(current, form);
                urls[current] = true;
                count++;
            }
        }

        private string currentPage(string Page) {
            return Page;
        }

        public void Download(string url, Form1 form) {
            try {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                Thread ParseTh = new Thread(() => Parse(html));
                ParseTh.Start();
                ParseTh.Join();
                //Parse(html);

                string fileName = filePath + "\\" + count.ToString() + ".html";
                File.WriteAllText(fileName, html, Encoding.UTF8);
                form.Invoke((MethodInvoker)(() => form.AddDownloadMessage(url, true, "Very good~")));
            }
            catch (Exception ex) {
                form.Invoke((MethodInvoker)(() => form.AddDownloadMessage(url, false, ex.Message)));
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
