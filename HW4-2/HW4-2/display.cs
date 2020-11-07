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
    public partial class displayWindow : Form {
        private OrderService service;
        private List<Order> ordersToDisplay;
        public displayWindow(OrderService service) {
            InitializeComponent();
            this.service = service;
            this.ordersToDisplay = service.gainOrderList();
            displayOrder();
            this.orderView.CellClick += List_CellClick;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
        }

        public void renewService(OrderService service) {
            this.service = service;
            refresh(service.gainOrderList());
        }

        public displayWindow(OrderService service, List<Order> showList) {
            InitializeComponent();
            this.service = service;
            this.ordersToDisplay = showList;
            displayOrder();
        }

        public void refresh(List<Order> showList) {
            this.ordersToDisplay = showList;
            orderView.Rows.Clear();
            displayOrder();
        }

        public void renewCell(int index, OrderDetails details, int detailID) {
            orderView.Rows[index].Cells[1].Value = details.objectID;
            orderView.Rows[index].Cells[2].Value = details.objectName;
            orderView.Rows[index].Cells[3].Value = details.supplier;
            orderView.Rows[index].Cells[4].Value = details.buyer;
            orderView.Rows[index].Cells[5].Value = details.num;
            orderView.Rows[index].Cells[6].Value = details.unitPrice;
            orderView.Rows[index].Cells[7].Value = details.totalPrice;
            int orderID =  int.Parse(orderView.Rows[index].Cells[0].Value.ToString());
            service.changeDetail(orderID, detailID, details);
            order_management_system system = (order_management_system)this.Owner;
            system.renewService(service);

        }

        public void displayOrder() {
            for(int i = 0; i < ordersToDisplay.Count; i++) {
                List<OrderDetails> details = ordersToDisplay[i].getDetail();
                for (int j = 0; j < details.Count; j++) {
                    DataGridViewRow row = new DataGridViewRow();
                    int index = orderView.Rows.Add(row);
                    orderView.Rows[index].Cells[0].Value = ordersToDisplay[i].orderID;
                    orderView.Rows[index].Cells[1].Value = details[j].objectID;
                    orderView.Rows[index].Cells[2].Value = details[j].objectName;
                    orderView.Rows[index].Cells[3].Value = details[j].supplier;
                    orderView.Rows[index].Cells[4].Value = details[j].buyer;
                    orderView.Rows[index].Cells[5].Value = details[j].num;
                    orderView.Rows[index].Cells[6].Value = details[j].unitPrice;
                    orderView.Rows[index].Cells[7].Value = details[j].totalPrice;
                    orderView.Rows[index].Cells[8].Value = j;
                }
            }
        }

        private void List_CellClick(object sender, DataGridViewCellEventArgs e) {
            int index = e.RowIndex;
            int orderID = int.Parse(orderView.Rows[index].Cells[0].Value.ToString());
            string objID = orderView.Rows[index].Cells[1].Value.ToString();
            string objName = orderView.Rows[index].Cells[2].Value.ToString();
            string supplier = orderView.Rows[index].Cells[3].Value.ToString();
            string buyer = orderView.Rows[index].Cells[4].Value.ToString();
            string num = orderView.Rows[index].Cells[5].Value.ToString();
            string unitPrice = orderView.Rows[index].Cells[6].Value.ToString();
            string totalPrice = orderView.Rows[index].Cells[7].Value.ToString();
            string detailID = orderView.Rows[index].Cells[8].Value.ToString();
            OrderDetails oldDetails = new OrderDetails(objID, objName, supplier, buyer, int.Parse(num), float.Parse(unitPrice));
            Modify modifyWindow = new Modify(oldDetails, index, detailID, orderID, service);
            modifyWindow.Show(this);
        }

        private void find_btn_Click(object sender, EventArgs e) {
            Find findWindow = new Find(service);
            findWindow.Show(this);
        }

        private void exportButton_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Choose the directory";
            sfd.InitialDirectory = @"C:\";
            sfd.Filter = "文本文件| *.xml";
            sfd.ShowDialog();

            string path = sfd.FileName;
            if (path == "") {
                return;
            }

            service.export(path);
        }

        private void importButton_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a xml file";
            //初始目录
            ofd.InitialDirectory = @"C:\";
            //设定文件类型
            ofd.Filter = "文本文件 | *.txt";
            ofd.ShowDialog();

            //获得在打开文件对话框中选择的文件的路径
            string path = ofd.FileName;
            if (path == "") {
                return;
            }

            service.import(path);
            order_management_system system = (order_management_system)this.Owner;
            system.renewService(service);
        }
    }
}
