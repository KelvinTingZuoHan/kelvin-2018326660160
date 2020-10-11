using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
    [Serializable]
    public class Order : IComparable  //单个订单项
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public double Money { get; set; }
        public string Date { get; set; }

        public List<OrderItem> orderItem = new List<OrderItem>();

        public Order()//无参构造函数
        {
            this.Id = 0;
            this.Customer = string.Empty;
            this.Money = 0;
            this.Date = string.Empty;

        }
        public int CompareTo(object obj)
        {
            Order a = obj as Order;
            return this.Id.CompareTo(a.Id);
        }
        public override bool Equals(object obj)
        {
            Order a = obj as Order;
            return this.Id == a.Id;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(Id);
        }
        public Order(int id, string customer, string date)
        {
            this.Id = id;
            this.Customer = customer;
            this.Date = date;
        }
        public void getAllPrice()  //计算总价
        {
            double i = 0;
            foreach (OrderItem a in this.orderItem)
            {
                i = i + a.getPrice();
            }
            this.Money = i;


        }

        public void addOrderItem(string name, int number, double price)   //添加订单项
        {
            OrderItem a = new OrderItem(name, number, price);
            this.orderItem.Add(a);
        }
        public void RemoveOrderItem() //删除订单项
        {
            try
            {
                Console.WriteLine("请输入订单明细序号删除相应订单明细：");
                int a = Convert.ToInt32(Console.ReadLine());
                this.orderItem.RemoveAt(a);
                Console.WriteLine("删除成功");
                Console.WriteLine("-------------------------");
            }
            catch
            {
                Console.WriteLine("输入序号错误");
            }
        }

        public void showOrderItem()  //展示订单项
        {
            Console.WriteLine("序号 名称 数量 单价");
            foreach (OrderItem a in this.orderItem)
            {

                Console.WriteLine("-----------------------");
                Console.WriteLine("{0} {1} {2} {3}", this.orderItem.IndexOf(a), a.Name, a.Number, a.Price);
            }
        }

    }
}
