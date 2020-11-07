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
    public partial class Modify : Form {

        private int orderID;
        private int cellIndex;
        private int detailID;
        private OrderService service;
        public Modify(OrderDetails details, int cellIndex, string detailID, int orderID, OrderService service) {
            InitializeComponent();
            setText(details);
            totalPrice_text.Enabled = false;
            this.cellIndex = cellIndex;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.detailID = int.Parse(detailID);
            this.orderID = orderID;
            this.service = service;
        }

        public void setText(OrderDetails details) {
            objID_text.Text = details.objectID;
            objName_text.Text = details.objectName;
            supllier_text.Text = details.supplier;
            buyer_text.Text = details.buyer;
            num_text.Text = details.num.ToString();
            unitPrice_text.Text = details.unitPrice.ToString();
            totalPrice_text.Text = (details.num * details.unitPrice).ToString();
        }

        private void confirm_btn_Click(object sender, EventArgs e) {
            displayWindow display = (displayWindow)this.Owner;
            bool numParse = int.TryParse(num_text.Text, out int num);
            bool unitParse = float.TryParse(unitPrice_text.Text, out float unitPrice);
            if (numParse && unitParse) {
                OrderDetails newDetail = new OrderDetails(objID_text.Text, objName_text.Text, supllier_text.Text, buyer_text.Text, int.Parse(num_text.Text), int.Parse(unitPrice_text.Text));
                display.renewCell(cellIndex, newDetail, detailID);
                this.Close();
            }

            else {
                add_text.ForeColor = Color.Red;
                add_text.Text = "Number character illegal!";
            }
        }

        private void delete_btn_Click(object sender, EventArgs e) {
            service.removeDetail(orderID, detailID);
            displayWindow displayWindow = (displayWindow)this.Owner;
            displayWindow.renewService(service);
            this.Close();
        }
    }
}
