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
    public partial class Add : Form {
        private OrderService service;
        public Add(OrderService service) {
            InitializeComponent();
            this.service = service;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
        }
        public void renewService(OrderService service) {
            this.service = service;
        }

        private void confirm_btn_Click(object sender, EventArgs e) {
            string objID = objID_text.Text;
            string objName = objName_text.Text;
            string supplier = supllier_text.Text;
            string buyer = buyer_text.Text;
            bool numConvert = int.TryParse(num_text.Text, out int num);
            bool unitPriceConvert = float.TryParse(unitPrice_text.Text, out float unitPrice);
            if (numConvert && unitPriceConvert) {
                OrderDetails newDetails = new OrderDetails(objID, objName, supplier, buyer, num, unitPrice);
                int sameID = service.isSameDetailsExsist(newDetails);
                if (sameID == -1) {
                    int newID = service.addOrder();
                    service.addDetails(newID, objID, objName, supplier, buyer, num, unitPrice);
                    warning warningWindow = new warning();
                    warningWindow.setText("Succeeded", "Data has been entered");
                    warningWindow.Show();
                    order_management_system system = (order_management_system)this.Owner;
                    system.renewService(service);
                    this.Close();
                }

                else {
                    ChooseOrder chooseWindow = new ChooseOrder(service, newDetails);
                    order_management_system system = (order_management_system)this.Owner;
                    chooseWindow.Show(system);
                    this.Close();
                }
            }

            else {
                warning warningWindow = new warning();
                warningWindow.setText("Warning!", "Character illegal.");
                warningWindow.Show();
            }
        }

        public OrderService gainService() {
            return this.service;
        }
    }
}
