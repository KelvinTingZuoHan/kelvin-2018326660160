using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_2 {
    public class Order {
        public int orderID { get; set; }

        private float totalPrice;

        private List<OrderDetails> orderDetails;

        public Order() {

        }

        public void setDetail(int detailID, OrderDetails details) {
            orderDetails[detailID] = details;
        }

        public void removeDetail(int detailID) {
            orderDetails.RemoveAt(detailID);
        }

        public void WriteXML(string Path) {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Order));

            var path = Path;
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, this);
            file.Close();
        }

        public List<OrderDetails> getDetail() {
            return orderDetails;
        }

        public void gainDetails(List<OrderDetails> orderDetails) {
            this.orderDetails = orderDetails;
        }

        public float displayPrice() {
            return totalPrice;
        }

        public Order(int orderID) {
            this.orderID = orderID;
            orderDetails = new List<OrderDetails>();
            this.totalPrice = 0;
        }

        // Add order details
        public void addDetails(string objectID, string objectName,
            string supplier, string buyer, int num, float unitPrice) {
            OrderDetails newDetail = new OrderDetails(objectID, objectName, supplier, buyer, num, unitPrice);
            for (int i = 0; i < orderDetails.Count; i++) {
                if (orderDetails[i].Equals(newDetail)) {
                    orderDetails[i].num += newDetail.num;
                    SumUp();
                    //Console.WriteLine("\nSame order has been stored in DataBase, merging...");
                    //Console.WriteLine($"Now you have {orderDetails.Count} orders in total.");
                    return;
                }
            }

            //Console.WriteLine("\nadding...");
            orderDetails.Add(newDetail);
            //Console.WriteLine($"Now you have {orderDetails.Count} orders in total.");
            SumUp();
            return;
        }

        // calculate the total price
        public void SumUp() {
            totalPrice = 0;
            foreach (OrderDetails detail in orderDetails) {
                totalPrice += detail.unitPrice * detail.num;
                detail.totalPrice = detail.num * detail.unitPrice;
            }
        }
    }
}
