using System;

namespace Merge_sort
{
    internal class Program
    {
        static void print(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i].ToString("D") + ' ');
            }
            Console.Write('\n');
        }
        static void merge(int[] list, int left, int mid, int right)
        {
            int i, j, k, l;
            i = left;
            j = mid + 1;
            k = left;
            int[] sorted = new int[list.Length];

            while (i <= mid && j <= right)
            {
                if (list[i] <= list[j]) sorted[k++] = list[i++];
                else sorted[k++] = list[j++];
            }
            if (i > mid) for (l = j; l <= right; l++) sorted[k++] = list[l];
            else for (l = i; l <= mid; l++) sorted[k++] = list[l];

            for (l = left; l <= right; l++) list[l] = sorted[l];
        }
        static void merge_sort(int[] list, int left, int right)
        {
            int mid;
            if (left < right) {
                mid = (left + right) / 2;
                merge_sort(list, left, mid);
                merge_sort(list, mid + 1, right);
                merge(list, left, mid, right);
            }
        }
        static void Main(string[] args)
        {
            int[] list = { 5, 3, 8, 4, 1, 6, 2, 7 };
            Console.Write("정렬 전 : ");
            print(list);

            merge_sort(list, 0, list.Length - 1);
            Console.Write("정렬 후 : ");
            print(list);

        }

    }
}
