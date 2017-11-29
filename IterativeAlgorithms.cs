using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort
{
    class IterativeAlgorithms
    {
        public static int Sum(int n)
        {
            int s = 0;

            for (int i = 0; i <= n; i++)
                s += i;

            return s;
        }

        public static long Product(int n)
        {
            long p = 1;

            for (int i = 1; i <= n; i++)
                p = p * i;

            return p;
        }

        public static int Fibonacci(int n)
        {
            int k = 0;
            int a = 0;
            int b = 1;

            if (n == 0) return 0;
            if (n == 1) return 1;

            for (int i = 2; i <= n; i++)
            {
                k = a + b;
                a = b;
                b = k;
            }
            return k;
        }
    }
}
