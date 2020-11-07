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
    public partial class ChooseOrder : Form {
        private OrderService service;
        private OrderDetails newDetail;
        public ChooseOrder(OrderService service, OrderDetails details) {
            InitializeComponent();
            this.service = service;
            this.newDetail = details;
            int OrderNum = orderNum();
            List<int> orderIDs = service.gainOrderID();
            for (int i = 0; i < OrderNum; i++) {
                orderBox.Items.Add(orderIDs[i]);
            }
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
        }

        public int orderNum() {
            return service.orderNum();
        }

        private void OK_btn_Click(object sender, EventArgs e) {
            object index = orderBox.SelectedItem;
            if (index != null)  {
                service.addDetails(int.Parse(index.ToString()), newDetail.objectID, newDetail.objectName, newDetail.supplier, newDetail.buyer, newDetail.num, newDetail.unitPrice);
                order_management_system system = (order_management_system)this.Owner;
                system.renewService(service);
                warning warningWindow = new warning();
                warningWindow.setText("Succeeded", "Data has been entered");
                warningWindow.Show();
                this.Close();
            }
            else {
                warning_label.Text = "Click it to choose!";
                warning_label.ForeColor = Color.Red;
            }
            
        }
        private void cancel_btn_Click(object sender, EventArgs e) {
            int newID = service.addOrder();
            service.addDetails(newID, newDetail.objectID, newDetail.objectName, newDetail.supplier, newDetail.buyer, newDetail.num, newDetail.unitPrice);
            order_management_system system = (order_management_system)this.Owner;
            system.renewService(service);
            warning warningWindow = new warning();
            warningWindow.setText("Succeeded", "Data has been entered");
            warningWindow.Show();
            this.Close();
        }
    }
}
