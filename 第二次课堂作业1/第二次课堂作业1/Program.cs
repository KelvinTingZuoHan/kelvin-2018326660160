using System;

namespace 第二次课堂作业1
{
    abstract class Shape
    {
        //面积
        public abstract double Area();
        //周长
        public abstract double Perimeter();
        //初始化数据
        public abstract void Initialization();
    }

    //圆形
    class Circle : Shape
    {
        double r;
        public Circle(double r)
        {
            Initialization();
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * r;
        }

        public override void Initialization()
        {
            while (true)
            {
                Console.WriteLine("请选择输入圆的半径or直径，如下:");
                Console.WriteLine("1、半径 2、直径");
                string rStr = Console.ReadLine();
                string result = "";
                if (rStr == "1")
                {
                    Console.WriteLine("请输入圆的半径：");
                    result = Console.ReadLine();
                    if (!double.TryParse(result, out r))
                    {
                        Console.Write("输入数字非法，");
                        continue;
                    }
                    break;
                }
                else if (rStr == "2")
                {
                    Console.WriteLine("请输入圆的直径：");
                    result = Console.ReadLine();
                    if (!double.TryParse(result, out r))
                    {
                        Console.Write("输入数字非法，");
                        continue;
                    }
                    r = r / 2;
                    break;
                }
                else
                {
                    Console.Write("输入数字非法，");
                    continue;
                }
            }
        }
    }
    //长方形
    class Rectangle : Shape
    {
        double width;
        double height;
        public Rectangle(double width)
        {
            Initialization();
        }

        public override double Area()
        {
            return width * height;
        }

        public override double Perimeter()
        {
            return 2 * (width + height);
        }

        public override void Initialization()
        {
            while (true)
            {
                Console.WriteLine("请选择输入长方形的长：");
                string widthStr = Console.ReadLine();
                Console.WriteLine("请选择输入长方形的宽：");
                string heightStr = Console.ReadLine();
                if (!double.TryParse(widthStr, out width) || !double.TryParse(heightStr, out height))
                {
                    Console.Write("输入数据出现非法字符，");
                    continue;
                }
                break;
            }
        }
    }

    //正方形
    class Square : Shape
    {
        double width;
        private double height;

        public Square(double width)
        {
            Initialization();
        }

        public Square(double width, double height) : this(width)
        {
            this.height = height;
        }

        public override double Area()
        {
            return Math.Pow(width, 2);
        }

        public override double Perimeter()
        {
            return 4 * width;
        }

        public override void Initialization()
        {
            while (true)
            {
                Console.WriteLine("请输入正方形的边长：");
                string widthStr = Console.ReadLine();
                if (!double.TryParse(widthStr, out width))
                {
                    Console.Write("输入数据出现非法字符，");
                    continue;
                }
                break;
            }
        }
    }

    //三角形
    class Triangle : Shape
    {
        double height;
        double bottom;
        double side1;
        double side2;
        double side3;
        public Triangle()
        {
            Initialization();
        }

        public override double Area()
        {
            return bottom * height / 2;
        }

        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }

        public override void Initialization()
        {
            while (true)
            {
                Console.Write("请输入三角形的底：");
                string bottomStr = Console.ReadLine();
                Console.Write("请输入三角形的高：");
                string heightStr = Console.ReadLine();
                Console.Write("请输入三角形第1个边长：");
                string side1Str = Console.ReadLine();
                Console.Write("请输入三角形第2个边长：");
                string side2Str = Console.ReadLine();
                Console.Write("请输入三角形第3个边长：");
                string side3Str = Console.ReadLine();
                if (!double.TryParse(bottomStr, out bottom) || !double.TryParse(heightStr, out height)
                     || !double.TryParse(side1Str, out side1) || !double.TryParse(side2Str, out side2)
                     || !double.TryParse(side3Str, out side3))
                {
                    Console.WriteLine("您输入的数据出现非法字符，请重新输入！");
                    continue;
                }
                break;
            }
        }
    }
    //工厂
    class Factory
    {
        public static Shape CreateShape(string name, double r, double width, double height)
        {
            switch (name)
            {

                case "1": return new Circle(r);
                case "2": return new Rectangle(width);
                case "3": return new Square(width, height);
                default:
                    Console.WriteLine("系统找不到您选择的形状！");
                    Console.ReadKey();
                    return null;
            }
        }

       
    }

    //控制台主程序
    class project
    {
        static void Main(string[] args)
        {
            //输入
            Console.WriteLine("请选择您要计算的形状，如下：");
            Console.WriteLine("1、圆 2、正方形 3、长方形 4、三角形");
            string name = Console.ReadLine();

            Shape shape = Factory.CreateShape( name);
            if (shape != null)
            {
                Console.WriteLine("面积为：{0}\r\n周长为：{1}", shape.Area(), shape.Perimeter());
            }
            Console.Write("系统找不到指定的矩形，按任意键结束……");
            Console.ReadKey();
        }
    }
}
