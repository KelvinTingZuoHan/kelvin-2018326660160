using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_2 {
    public class OrderService {
        private List<Order> orderList;

        public OrderService() {
            orderList = new List<Order>();
        }

        public List<Order> gainOrderList() {
            return orderList;
        }

        public void displayOrder(int orderID) {
            foreach (Order order in orderList) {
                if (order.orderID == orderID) {
                    Console.WriteLine("order ID: " + orderID + "total price: " + order.displayPrice());
                }
            }
        }

        public int orderNum() {
            return orderList.Count;
        }

        public List<int> gainOrderID() {
            List<int> IDs = new List<int>();
            foreach(Order order in orderList) {
                IDs.Add(order.orderID);
            }
            return IDs;
        }

        public void displayAllDetails() {
            foreach (Order order in orderList) {
                displayOrderDetails(order.orderID);
            }
        }

        public void displayOrderDetails(int orderID) {
            foreach (Order order in orderList) {
                if (order.orderID == orderID) {
                    List<OrderDetails> details = order.getDetail();
                    foreach (OrderDetails orderDetail in details) {
                        Console.Write("order ID: " + orderID + ", objectID: " + orderDetail.objectID + ", objectName: " + orderDetail.objectName + ", supplier: " + orderDetail.supplier
                            + ", buyer: " + orderDetail.buyer + ", num: " + orderDetail.num + ", unit price: " + orderDetail.unitPrice + ", total price: " + orderDetail.totalPrice + "\n");
                    }
                    Console.Write("                                   ============================================ Order total price: " + order.displayPrice() + "\n\n");
                    break;
                }
            }
        }

        public int Count() {
            return orderList.Count();
        }

        public bool isSameIDExsist(int ID) {
            foreach (Order order in orderList) {
                if(order.orderID == ID) {
                    return true;
                }
            }
            return false;
        }

        public int isSameDetailsExsist(OrderDetails newDetails) {
            foreach(Order order in orderList) {
                foreach(OrderDetails details in order.getDetail()) {
                    if (details.Equals(newDetails)) {
                        return order.orderID;
                    }
                }
            }
            return -1;
        }

        public int addOrder() {
            int orderID = orderList.Count + 1;
            Order newOrder = new Order(orderID);
            orderList.Add(newOrder);
            return orderID;
        }

        public List<int> findOrderByTotalPriceSmaller(List<Order> orderList, float price, bool equal) {
            List<int> resultOrderID = new List<int>();
            List<Order> results = new List<Order>();

            if (equal) {
                var query = orderList.Where(order => order.displayPrice() <= price);
                results = query.ToList();
            }

            else {
                var query = orderList.Where(order => order.displayPrice() < price);
                results = query.ToList();
            }

            if (results != null) {
                foreach (Order order in results) {
                    resultOrderID.Add(order.orderID);
                    // Console.Write("order ID: " + order.orderID + ", total price: " + order.displayPrice() + "\n");
                }
            }
            return resultOrderID;
        }

        public List<int> findOrderByTotalPriceGreater(List<Order> orderList, float price, bool equal) {
            List<int> resultOrderID = new List<int>();
            List<Order> results = new List<Order>();

            if (equal) {
                var query = orderList.Where(order => order.displayPrice() >= price);
                results = query.ToList();
            }

            else {
                var query = orderList.Where(order => order.displayPrice() > price);
                results = query.ToList();
            }

            if (results != null) {
                foreach (Order order in results) {
                    resultOrderID.Add(order.orderID);
                    // Console.Write("order ID: " + order.orderID + ", total price: " + order.displayPrice() + "\n");
                }
            }
            return resultOrderID;
        }

        public List<int> findOrderByObjectID(List<Order> orderList, string objID) {
            List<int> resultOrderID = new List<int>();
            foreach (Order order in orderList) {
                List<OrderDetails> details = order.getDetail();
                var query = details.Where(detail => detail.objectID == objID);
                List<OrderDetails> result = query.ToList();
                if (result.Count != 0) {
                    resultOrderID.Add(order.orderID);
                }
            }
            return resultOrderID;
        }

        public List<int> findOrderByObjectName(List<Order> orderList, string objName) {
            List<int> resultOrderID = new List<int>();
            foreach (Order order in orderList) {
                List<OrderDetails> details = order.getDetail();
                var query = details.Where(detail => detail.objectName == objName);
                List<OrderDetails> result = query.ToList();
                if (result.Count != 0) {
                    resultOrderID.Add(order.orderID);
                }
            }
            return resultOrderID;
        }

        public List<int> findOrderBySupplier(List<Order> orderList, string supplier) {
            List<int> resultOrderID = new List<int>();
            foreach (Order order in orderList) {
                List<OrderDetails> details = order.getDetail();
                var query = details.Where(detail => detail.supplier == supplier);
                List<OrderDetails> result = query.ToList();
                if (result.Count != 0) {
                    resultOrderID.Add(order.orderID);
                }
            }
            return resultOrderID;
        }

        public List<int> findOrderByBuyer(List<Order> orderList, string buyer) {
            List<int> resultOrderID = new List<int>();
            foreach (Order order in orderList) {
                List<OrderDetails> details = order.getDetail();
                var query = details.Where(detail => detail.buyer == buyer);
                List<OrderDetails> result = query.ToList();
                if (result.Count != 0) {
                    resultOrderID.Add(order.orderID);
                }
            }
            return resultOrderID;
        }

        public List<int> findOrderByNumGreater(List<Order> orderList, int num, bool equal) {
            List<int> resultOrderID = new List<int>();
            foreach (Order order in orderList) {
                List<OrderDetails> details = order.getDetail();
                List<OrderDetails> result = new List<OrderDetails>();

                if (equal) {
                    var query = details.Where(detail => detail.num >= num);
                    result = query.ToList();
                }

                else {
                    var query = details.Where(detail => detail.num > num);
                    result = query.ToList();
                }

                if (result.Count != 0) {
                    resultOrderID.Add(order.orderID);
                }
            }
            return resultOrderID;
        }
        public List<int> findOrderByNumSmaller(List<Order> orderList, int num, bool equal) {
            List<int> resultOrderID = new List<int>();
            foreach (Order order in orderList) {
                List<OrderDetails> details = order.getDetail();
                List<OrderDetails> result = new List<OrderDetails>();

                if (equal) {
                    var query = details.Where(detail => detail.num <= num);
                    result = query.ToList();
                }

                else {
                    var query = details.Where(detail => detail.num < num);
                    result = query.ToList();
                }

                if (result.Count != 0) {
                    resultOrderID.Add(order.orderID);
                }
            }
            return resultOrderID;
        }

        public List<int> findOrderByUnitPriceGreater(List<Order> orderList, float unitPrice, bool equal) {
            List<int> resultOrderID = new List<int>();
            foreach (Order order in orderList) {
                List<OrderDetails> details = order.getDetail();
                List<OrderDetails> result = new List<OrderDetails>();

                if (equal) {
                    var query = details.Where(detail => detail.unitPrice >= unitPrice);
                    result = query.ToList();
                }

                else {
                    var query = details.Where(detail => detail.unitPrice > unitPrice);
                    result = query.ToList();
                }

                if (result.Count != 0) {
                    resultOrderID.Add(order.orderID);
                }
            }
            return resultOrderID;
        }

        public List<int> findOrderByUnitPriceSmaller(List<Order> orderList, float unitPrice, bool equal) {
            List<int> resultOrderID = new List<int>();
            foreach (Order order in orderList) {
                List<OrderDetails> details = order.getDetail();
                List<OrderDetails> result = new List<OrderDetails>();

                if (equal) {
                    var query = details.Where(detail => detail.unitPrice <= unitPrice);
                    result = query.ToList();
                }

                else {
                    var query = details.Where(detail => detail.unitPrice < unitPrice);
                    result = query.ToList();
                }

                if (result.Count != 0) {
                    resultOrderID.Add(order.orderID);
                }
            }
            return resultOrderID;
        }

        public List<Order> find(string objectID, string objectName, string supplier, string buyer, string strNum, string strUnitPrice, string strTotalPrice) {
            bool numParsed = int.TryParse(strNum, out int num);
            bool unitPriceParsed = float.TryParse(strUnitPrice, out float unitPrice);
            List<int> resultID = new List<int>();

            if (objectID != "") {
                resultID = findOrderByObjectID(orderList, objectID);
                if (resultID == null) {
                    return null;
                }
            }

            if(objectName != "") {
                List<Order> Order = new List<Order>();
                foreach (int ID in resultID) {
                    Order.Add(gainOrder(ID));
                }
                resultID = findOrderByObjectName(Order, objectName);
                if (resultID == null) {
                    return null;
                }
            }

            if (supplier != "") {
                List<Order> Order = new List<Order>();
                foreach (int ID in resultID) {
                    Order.Add(gainOrder(ID));
                }
                resultID = findOrderBySupplier(Order, supplier);
                if (resultID == null) {
                    return null;
                }
            }

            if (buyer != "") {
                List<Order> Order = new List<Order>();
                foreach (int ID in resultID) {
                    Order.Add(gainOrder(ID));
                }
                resultID = findOrderByBuyer(Order, buyer);
                if (resultID == null) {
                    return null;
                }
            }

            if (strNum != "" || strNum.Length == 2 || strNum.Length == 3) {
                List<Order> Order = new List<Order>();
                foreach (int ID in resultID) {
                    Order.Add(gainOrder(ID));
                }

                switch (strNum.Length) {
                    case 2: if (strNum[0] == '<') { 
                                resultID = findOrderByNumSmaller(Order, strNum[1], false);
                                break;
                            }

                            if (strNum[0] == '>') {
                                resultID = findOrderByNumGreater(Order, strNum[1], false);
                                break;
                            } break;

                    case 3: if (strNum[0] == '<' && strNum[1] == '=') {
                                resultID = findOrderByNumSmaller(Order, strNum[2], true);
                                break;
                            }

                            if (strNum[0] == '>' && strNum[1] == '=') {
                                resultID = findOrderByNumGreater(Order, strNum[2], true);
                                break;
                            } break;

                    default: break;
                }
                if (resultID == null) {
                    return null;
                }
            }

            if (strUnitPrice != "" || strUnitPrice.Length == 2 || strUnitPrice.Length == 3) {
                List<Order> Order = new List<Order>();
                foreach (int ID in resultID) {
                    Order.Add(gainOrder(ID));
                }

                switch (strNum.Length) {
                    case 2:
                        if (strNum[0] == '<') {
                            resultID = findOrderByUnitPriceSmaller(Order, strUnitPrice[1], false);
                            break;
                        }

                        if (strNum[0] == '>') {
                            resultID = findOrderByUnitPriceGreater(Order, strUnitPrice[1], false);
                            break;
                        }
                        break;

                    case 3:
                        if (strNum[0] == '<' && strNum[1] == '=') {
                            resultID = findOrderByUnitPriceSmaller(Order, strUnitPrice[2], true);
                            break;
                        }

                        if (strNum[0] == '>' && strNum[1] == '=') {
                            resultID = findOrderByUnitPriceGreater(Order, strUnitPrice[2], true);
                            break;
                        }
                        break;

                    default: break;
                }
                if (resultID == null) {
                    return null;
                }
            }

            if (strTotalPrice != "" || strTotalPrice.Length == 2 || strTotalPrice.Length == 3) {
                List<Order> Order = new List<Order>();
                foreach (int ID in resultID) {
                    Order.Add(gainOrder(ID));
                }

                switch (strNum.Length) {
                    case 2:
                        if (strNum[0] == '<') {
                            resultID = findOrderByTotalPriceSmaller(Order, strTotalPrice[1], false);
                            break;
                        }

                        if (strNum[0] == '>') {
                            resultID = findOrderByTotalPriceGreater(Order, strTotalPrice[1], false);
                            break;
                        }
                        break;

                    case 3:
                        if (strNum[0] == '<' && strNum[1] == '=') {
                            resultID = findOrderByTotalPriceSmaller(Order, strTotalPrice[2], true);
                            break;
                        }

                        if (strNum[0] == '>' && strNum[1] == '=') {
                            resultID = findOrderByTotalPriceGreater(Order, strTotalPrice[2], true);
                            break;
                        }
                        break;

                    default: break;
                }
                if (resultID == null) {
                    return null;
                }
            }

            List<Order> ID2Order = new List<Order>();
            foreach (int ID in resultID) {
                ID2Order.Add(gainOrder(ID));
            }

            return ID2Order;
        }

        private Order gainOrder(int ID) {
            foreach(Order order in orderList) {
                if(order.orderID == ID) {
                    return order;
                }
            }
            return null;
        }

        public void addDetails(int orderID, string objectID, string objectName, string supplier, string buyer, int num, float unitPrice) {
            for (int i = 0; i < orderList.Count(); i++) {
                if (orderID == orderList[i].orderID) {
                    orderList[i].addDetails(objectID, objectName, supplier, buyer, num, unitPrice);
                    return;
                }
            }
        }

        public List<Order> Sort(List<Order> orders, int sortBy, int upOrDown) {
            switch(sortBy) {
                case 1:
                    if (upOrDown == 1) {
                        foreach (Order order in orders) {
                            List<OrderDetails> details = order.getDetail();
                            var query = details.OrderBy(OrderDetails => OrderDetails.objectID);
                            List<OrderDetails> result = query.ToList();
                            order.gainDetails(result);
                        }
                        return orders;
                    }

                    if (upOrDown == 2) {
                        foreach (Order order in orders) {
                            List<OrderDetails> details = order.getDetail();
                            var query = details.OrderByDescending(OrderDetails => OrderDetails.objectID);
                            List<OrderDetails> result = query.ToList();
                            order.gainDetails(result);
                        }
                        return orders;
                    }
                    break;

                case 2:
                    if (upOrDown == 1) {
                        foreach (Order order in orders) {
                            List<OrderDetails> details = order.getDetail();
                            var query = details.OrderBy(OrderDetails => OrderDetails.objectName);
                            List<OrderDetails> result = query.ToList();
                            order.gainDetails(result);
                        }
                        return orders;
                    }

                    if (upOrDown == 2) {
                        foreach (Order order in orders) {
                            List<OrderDetails> details = order.getDetail();
                            var query = details.OrderByDescending(OrderDetails => OrderDetails.objectName);
                            List<OrderDetails> result = query.ToList();
                            order.gainDetails(result);
                        }
                        return orders;
                    }
                    break;

                case 3:
                    if (upOrDown == 1) {
                        foreach (Order order in orders) {
                            List<OrderDetails> details = order.getDetail();
                            var query = details.OrderBy(OrderDetails => OrderDetails.supplier);
                            List<OrderDetails> result = query.ToList();
                            order.gainDetails(result);
                        }
                        return orders;
                    }

                    if (upOrDown == 2) {
                        foreach (Order order in orders) {
                            List<OrderDetails> details = order.getDetail();
                            var query = details.OrderByDescending(OrderDetails => OrderDetails.supplier);
                            List<OrderDetails> result = query.ToList();
                            order.gainDetails(result);
                        }
                        return orders;
                    }
                    break;

                case 4:
                    if (upOrDown == 1) {
                        foreach (Order order in orders) {
                            List<OrderDetails> details = order.getDetail();
                            var query = details.OrderBy(OrderDetails => OrderDetails.buyer);
                            List<OrderDetails> result = query.ToList();
                            order.gainDetails(result);
                        }
                        return orders;
                    }

                    if (upOrDown == 2) {
                        foreach (Order order in orders) {
                            List<OrderDetails> details = order.getDetail();
                            var query = details.OrderByDescending(OrderDetails => OrderDetails.buyer);
                            List<OrderDetails> result = query.ToList();
                            order.gainDetails(result);
                        }
                        return orders;
                    }
                    break;

                case 5:
                    if (upOrDown == 1) {
                        foreach (Order order in orders) {
                            List<OrderDetails> details = order.getDetail();
                            var query = details.OrderBy(OrderDetails => OrderDetails.num);
                            List<OrderDetails> result = query.ToList();
                            order.gainDetails(result);
                        }
                        return orders;
                    }

                    if (upOrDown == 2) {
                        foreach (Order order in orders) {
                            List<OrderDetails> details = order.getDetail();
                            var query = details.OrderByDescending(OrderDetails => OrderDetails.num);
                            List<OrderDetails> result = query.ToList();
                            order.gainDetails(result);
                        }
                        return orders;
                    }
                    break;

                case 6:
                    if (upOrDown == 1) {
                        foreach (Order order in orders) {
                            List<OrderDetails> details = order.getDetail();
                            var query = details.OrderBy(OrderDetails => OrderDetails.unitPrice);
                            List<OrderDetails> result = query.ToList();
                            order.gainDetails(result);
                        }
                        return orders;
                    }

                    if (upOrDown == 2) {
                        foreach (Order order in orders) {
                            List<OrderDetails> details = order.getDetail();
                            var query = details.OrderByDescending(OrderDetails => OrderDetails.unitPrice);
                            List<OrderDetails> result = query.ToList();
                            order.gainDetails(result);
                        }
                        return orders;
                    }
                    break;

                case 7:
                    if (upOrDown == 1) {
                        foreach (Order order in orders) {
                            List<OrderDetails> details = order.getDetail();
                            var query = details.OrderBy(OrderDetails => OrderDetails.totalPrice);
                            List<OrderDetails> result = query.ToList();
                            order.gainDetails(result);
                        }
                        return orders;
                    }

                    if (upOrDown == 2) {
                        foreach (Order order in orders) {
                            List<OrderDetails> details = order.getDetail();
                            var query = details.OrderByDescending(OrderDetails => OrderDetails.totalPrice);
                            List<OrderDetails> result = query.ToList();
                            order.gainDetails(result);
                        }
                        return orders;
                    }
                    break;
                default: return null;
            }
            return null;
        }

        public bool removeOrder(string orderID) {
            bool flag = int.TryParse(orderID, out int ID);
            if (flag) {
                foreach (Order order in orderList) {
                    if (order.orderID == ID) {
                        orderList.Remove(order);
                        return true;
                    }
                }
                return false;
            }

            else {
                return flag;
            }
        }

        public Order import(string Path) {
            // Now we can read the serialized book ...  
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Order));
            System.IO.StreamReader file = new System.IO.StreamReader(
                @Path);
            Order overview = (Order)reader.Deserialize(file);
            file.Close();
            orderList.Add(overview);
            return overview;
        }

        public void export(string Path) {
            foreach(Order order in orderList) {
                order.WriteXML(Path);
            }
        }

        public void changeDetail(int orderID, int detailID, OrderDetails details) {
            foreach(Order order in orderList) {
                if (order.orderID == orderID) {
                    order.setDetail(detailID, details);
                    return;
                }
            }
        }
        
        public void removeDetail(int orderID, int detailID) {
            foreach (Order order in orderList) {
                if (order.orderID == orderID) {
                    order.removeDetail(detailID);
                    return;
                }
            }
        }
    }
}
