using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort
{
    public class SortingAlgorithms
    {
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

        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[min] > arr[j])
                        min = j;

                int aux = arr[i];
                arr[i] = arr[min];
                arr[min] = aux;
            }
            return arr;
        }

        public static int[] BubbleSort(int[] arr)
        {
            int aux = 0;

            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        aux = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = aux;
                    }
            return arr;
        }

        public static void Merge(int[] arr, int p, int q, int r)
        {
            int intMax = 100;
            int n1 = q - p + 1;
            int n2 = r - q;
            int i, j;
            int[] L = new int[n1];
            int[] R = new int[n2];

            for (i = 0; i < n1; i++)
                L[i] = arr[p + i - 1];
            for (j = 0; j < n2; j++)
                R[j] = arr[q + j];
            L[n1 + 1] = intMax;
            R[n2 + 1] = intMax;
            i = 1;
            j = 1;
            for (int k = p; k <= r; k++)
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i = i + 1;
                }
                else
                {
                    arr[k] = R[j];
                    j = j + 1;
                }
        }

        //static public void Merge(int[] numbers, int left, int mid, int right)
        //{
        //    int[] temp = new int[25];
        //    int i, left_end, num_elements, tmp_pos;

        //    left_end = (mid - 1);
        //    tmp_pos = left;
        //    num_elements = (right - left + 1);

        //    while ((left <= left_end) && (mid <= right))
        //    {
        //        if (numbers[left] <= numbers[mid])
        //            temp[tmp_pos++] = numbers[left++];
        //        else
        //            temp[tmp_pos++] = numbers[mid++];
        //    }

        //    while (left <= left_end)
        //        temp[tmp_pos++] = numbers[left++];

        //    while (mid <= right)
        //        temp[tmp_pos++] = numbers[mid++];

        //    for (i = 0; i < num_elements; i++)
        //    {
        //        numbers[right] = temp[right];
        //        right--;
        //    }
        //}

        public static void MergeSort(int[] arr, int p, int r)
        {
            int q;

            if (p < r)
            { 
                 q = (r + p) / 2;
                 MergeSort(arr, p, q);
                 MergeSort(arr, q + 1, r);
                 Merge(arr, p, q+1, r);
            }
        }
    }
}
    
