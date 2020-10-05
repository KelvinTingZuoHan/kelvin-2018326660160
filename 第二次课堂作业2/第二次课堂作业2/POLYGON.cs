using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二次课堂作业2
{
    class Dot
    {
        public double x, y;

        public Dot(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Vector
    {
        public double x, y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class shape
    {
        public List<Dot> vertex = new List<Dot>();
        public List<double> distance = new List<double>();
        public double Area = 0;

        public shape(List<Dot> vertex)
        {
            this.vertex = vertex;
            computeArea();
        }

        public void computeArea()
        {
            double sum = 0;
            for (int i = 0; i < vertex.Count - 1; i++)
            {
                sum += vertex[i].x * vertex[i + 1].y - vertex[i + 1].x * vertex[i].y;
            }

            if (sum < 0)
            {
                sum = -sum;
            }

            this.Area = 0.5 * sum;
        }

        // 计算边长
        public void computeEdgeLength()
        {
            for (int i = 0; i < vertex.Count() - 1; i++)
            {
                distance.Add(System.Math.Sqrt(System.Math.Pow(vertex[i].x - vertex[i + 1].x, 2) + System.Math.Pow(vertex[i].y - vertex[i + 1].y, 2)));
            }

            distance.Add(System.Math.Sqrt(System.Math.Pow(vertex[0].x - vertex[vertex.Count() - 1].x, 2) + System.Math.Pow(vertex[0].y - vertex[vertex.Count() - 1].y, 2)));
        }
    }
}

