using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort
{
    public class SortingAlgorithms
    {

        public static int[] BubbleSort(int[] arr)
        {
            int aux = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        aux = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = aux;
                    }
                }
            }
            return arr;
        }

        public static int[] InsertionSort(int[] arr)
        {
            for (int j = 1; j < arr.Length; j++)
            {
                int i = j - 1;
                int key = arr[j];

                while (i >= 0 && arr[i] > key)
                {
                    arr[i + 1] = arr[i];
                    i = i - 1;
                }
                arr[i + 1] = key;
            }
            return arr;
        }

        public static void Merge(int[] A, int p, int q, int r)
        {
            int intMax = Int32.MaxValue;
            int n1 = q - p + 1;
            int n2 = r - q;
            int i, j;
            int[] L = new int[n1 + 1];
            int[] R = new int[n2 + 1];

            for (i = 0; i < n1; i++)
            {
                L[i] = A[p + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = A[q + j + 1];
            }

            L[n1] = intMax;
            R[n2] = intMax;
            i = 0;
            j = 0;

            for (int k = p; k <= r; k++)
            {
                if (L[i] <= R[j])
                {
                    A[k] = L[i];
                    i += 1;
                }
                else
                {
                    A[k] = R[j];
                    j += 1;
                }
            }
        }

        public static void MergeSort(int[] A, int p, int r)
        {
            int q;

            if (p < r)
            {
                q = (int)Math.Floor((double)(r + p) / 2);
                MergeSort(A, p, q);
                MergeSort(A, q + 1, r);
                Merge(A, p, q, r);
            }
        }
    }
}
