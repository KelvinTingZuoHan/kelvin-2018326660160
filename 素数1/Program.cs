using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Xml.Schema;

namespace 素数1
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("请输入一个整数：");
                int num = Convert.ToInt32(Console.ReadLine());
                List<int> factors = Factors(num);
                Console.Write("素数因子：");
                factors.ForEach(f => Console.Write("\t" + f));
            }
            catch (Exception e)
            {
                Console.WriteLine($"错误：{e.Message}");

            }
        }

        private static List<int> Factors(int num)
        {
            List<int> factors = new List<int>();
            for (int factor = 2; factor * factor <= num; factor++)
                while (num % factor == 0)
                {
                    factors.Add(factor);
                    num = num / factor;

                }


            if (num != 1)
            {
                factors.Add(num);
            }
            return factors;
        }
    }

   
}