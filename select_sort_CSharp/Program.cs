using System;

namespace select_sort_CSharp
{
    internal class Program
    {
        static void swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
        
        static void print(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString("D") + ' ');
            }
            Console.Write('\n');
        }
        static void Main(string[] args)
        {
            int[] x = { 15, 12, 5, 16, 3 };
            Console.Write("정렬 전 : ");
            print(x);
            for (int i = 0; i < x.Length - 1; i++)
            {
                int leastNum = i;
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[leastNum] > x[j]) leastNum = j;
                }
                swap(x, i, leastNum);
            }
            Console.Write("정렬 후 : ");
            print(x);
        }
    }
}
