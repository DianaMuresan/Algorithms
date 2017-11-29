using System;

namespace InsertionSort
{
    public class RecursiveAlgorithms
    {
        public static long SumRecursiv(int n)
        {
            if (n == 0)
                return 0;

            return n + SumRecursiv(n - 1);
        }

        public static long ProductRecursiv(int n)
        {
            if (n == 0)
                return 1;

            return n * ProductRecursiv(n - 1);
        }

        public static int RecursiveFibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }
    }
}
