using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二次课堂作业3
{
    class Program
    {
        static void Main(string[] args)
        {
            myList<int> intArray = new myList<int>();
            intArray.Add(1);
            intArray.Add(2);
            intArray.Add(3);
            intArray.Add(4);
            //double sum = intArray.Sum();
            //double min = intArray.Max();
            //double max = intArray.Min();

            double max = 0;
            double min = 0;
            double sum = 0;

            intArray.ForEach(x => max = Math.Max(x, max));
            intArray.ForEach(x => min = Math.Min(x, min));
            intArray.ForEach(x => sum += x);
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("max: " + max);
            Console.WriteLine("min: " + min);
        }
    }
}
