using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPTILE {
    class Download_info {
        public string URL { set; get; }
        public string Status { set; get; }
        public string Message { set; get; }

        public Download_info(string url, string isSuccess, string Message) {
            this.URL = url;
            this.Status = isSuccess;
            this.Message = Message;
        }

    }
}
