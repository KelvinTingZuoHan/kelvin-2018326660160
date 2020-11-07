using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5 {
    class Program {
        static void Main(string[] args) {
            string startUrl = "http://www.cnblogs.com";
            string filePath = "Download/";
            Reptile crawler = new Reptile(startUrl, filePath, 10);
            crawler.Start();
        }
    }
}
