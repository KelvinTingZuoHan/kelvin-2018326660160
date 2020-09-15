using System;

namespace 第一次课堂练习_二_第三题埃氏筛法求素数
{
    class Prime
    {
        static void Main(string[] args)
        {
            const int N = 100;
            bool[] a = new bool[N + 1];
            for (int i = 2; i<=N;i++)
            {
                a[i] = true;
                
            }
            FP(a);
            for (int num = 2; num <= N + 1; num++)
            {
                if (a[num])
                {
                    Console.Write($"\t{num}");
                }
            }
        }
        private static bool[] FP (bool[] a)
        {
            for (int num = 2; num * num < a.Length; num++)
            {
                if (!a[num]) continue;
                for (int b = 2 * num; b < a.Length; b += num)
                {
                   a[b] = false;
                }
                
            }
            return a;

        }
    }
       
}
