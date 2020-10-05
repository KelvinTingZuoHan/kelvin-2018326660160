using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二次课堂作业3
{
    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    // 链表对象
    public class myList<T>
    {
        private Node<T> head, tail;

        public myList()
        {
            head = tail = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> newNode = new Node<T>(t);

            if (head == null)
            {
                head = tail = newNode;
            }

            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }

        // 求和
        public double Sum()
        {
            if (tail == null)
            {
                return 0xffff;
            }
            Node<T> tempNode = head;
            double sum = 0;
            while (tempNode != null)
            {
                try
                {
                    double data = (double)Convert.ChangeType(tempNode.Data, typeof(Double));
                    sum += data;
                    tempNode = tempNode.Next;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    break;
                }
            }
            return sum;
        }

        // 求最大值
        public double Max()
        {
            if (tail == null)
            {
                return 0xffff;
            }
            Node<T> tempNode = head;
            double max = (double)Convert.ChangeType(tempNode.Data, typeof(Double));
            while (tempNode != null)
            {
                try
                {
                    double data = (double)Convert.ChangeType(tempNode.Data, typeof(Double));
                    if (data >= max)
                    {
                        max = data;
                    }
                    tempNode = tempNode.Next;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    break;
                }
            }
            return max;
        }

        // 求最小值
        public double Min()
        {
            if (tail == null)
            {
                return 0xffff;
            }
            Node<T> tempNode = head;
            double min = (double)Convert.ChangeType(tempNode.Data, typeof(Double));
            while (tempNode != null)
            {
                try
                {
                    double data = (double)Convert.ChangeType(tempNode.Data, typeof(Double));
                    if (data <= min)
                    {
                        min = data;
                    }
                    tempNode = tempNode.Next;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    break;
                }
            }
            return min;
        }

        // 链表的foreach
        public void ForEach(Action<T> action)
        {
            for (var p = head; p != null; p = p.Next)
            {
                action(p.Data);
            }
        }


    }
}
