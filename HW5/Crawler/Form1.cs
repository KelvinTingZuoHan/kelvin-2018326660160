using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace REPTILE {
    delegate void renewUrlList(string url);
    public partial class Form1 : Form {
        private MyCrawler crawler;
        private string URLRegEx = "(https?|ftp|file)://[-A-Za-z0-9+&@#/%?=~_|!:,.;]+[-A-Za-z0-9+&@#/%=~_|]";
        public void addUrlList(string url) {
            Url_list.Items.Add(url);
        }

        public Form1() {
            InitializeComponent();
        }

        public void renewUrlList(string url) {
            Url_list.Items.Add(url);
        }

        public void AddDownloadMessage(string html, bool isSuccess, string message) {
            DataGridViewRow row = new DataGridViewRow();
            if (isSuccess) {
                downloadinfoBindingSource.Add(new Download_info(html, "Success", message));
            }
            else {
                downloadinfoBindingSource.Add(new Download_info(html, "Failed", message));
            }
            // int index = downloads_view.Rows.Add(row);
            // downloads_view.Rows[index].Cells[0].Value = html;
            // downloads_view.Rows[index].Cells[1].Value = isSuccess;
        }

        private void start_btn_Click(object sender, EventArgs e) {
            Url_list.Items.Clear();
            downloadinfoBindingSource.Clear();
            string StartURL = URL_text.Text;
            string foldPath = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Please select the download path:";
            if (dialog.ShowDialog() == DialogResult.OK) {
                foldPath = dialog.SelectedPath;
            }
            if (StartURL != "" && Regex.IsMatch(StartURL, URLRegEx) && foldPath != "") {
                crawler = new MyCrawler(StartURL, foldPath);
                crawler.Start(this);
            }
            else {
                Url_list.Items.Add("Error, URL is illegal!!!");
            }
        }
    }
}
