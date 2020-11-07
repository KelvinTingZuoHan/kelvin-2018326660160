using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_2 {
    public partial class order_management_system : Form {
        private OrderService service;
        public order_management_system() {
            InitializeComponent();
            this.service = new OrderService();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
        }

        public void renewService(OrderService service) {
            this.service = service;
        }

        private void add_btn_Click(object sender, EventArgs e) {
            Add addWindow = new Add(service);
            if (addWindow != null && !addWindow.IsDisposed) {
                addWindow.Show(this);
            }
        }

        private void find_btn_Click(object sender, EventArgs e) {
            Find findWindow = new Find(service);
            if (findWindow != null && !findWindow.IsDisposed) {
                findWindow.Show(this);
            }
        }

        private void modi_btn_Click(object sender, EventArgs e) {
            displayWindow displayWindow = new displayWindow(service);
            if (displayWindow != null && !displayWindow.IsDisposed) {
                displayWindow.Show(this);
            }
        }

        private void title_label_Click(object sender, EventArgs e)
        {

        }
    }
}
