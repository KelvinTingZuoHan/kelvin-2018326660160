using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 第二次课堂作业2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nodeNum = 0;
            List<shape> shapes = new List<shape>();
            Random ran = new Random();
            for (int i = 0; i < 10; i++)
            {
                nodeNum = ran.Next(1, 100);
                Console.WriteLine($"Node num: {nodeNum}");
                List<Dot> dots = new List<Dot>();

                for (int j = 0; j < nodeNum; j++)
                {
                    double x = ran.Next(-100, 100);
                    double y = ran.Next(-100, 100);
                    dots.Add(new Dot(x, y));
                }

                shapes.Add(new shape(dots));
            }

            double Area = 0;

            foreach (shape s in shapes)
            {
                Console.WriteLine($"each Area: {s.Area}");
                Area += s.Area;
            }

            Console.WriteLine($"Quadrangle Area: {Area}");
        }
    }
}
