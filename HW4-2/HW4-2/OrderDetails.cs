using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW4_2 {
    public class OrderDetails {
        public string objectID { get; set; }
        public string objectName { get; set; }
        public string supplier { get; set; }
        public string buyer { get; set; }
        public int num { get; set; }
        public float unitPrice { get; set; }
        public float totalPrice { get; set; }

        public OrderDetails() { }

        public OrderDetails(string objectID, string objectName, 
            string supplier, string buyer, int num, float unitPrice) {
            this.objectID = objectID;
            this.objectName = objectName;
            this.supplier = supplier;
            this.buyer = buyer;
            this.num = num;
            this.unitPrice = unitPrice;
            this.totalPrice = this.unitPrice * this.num;
        }

        public bool Equals(OrderDetails details) {
            bool flag = objectID == details.objectID &&
                        supplier == details.supplier &&
                        buyer == details.buyer;
            return flag;
        }

        public void WriteXML() {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(OrderDetails));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, this);
            file.Close();
        }
    }
}
