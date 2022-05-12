using System;

namespace quick_sort_CSharp
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
        static int partition(int[] list, int left, int right)
        {
            int pivot, temp;
            int low, high;

            pivot = list[left];
            low = left;
            high = right + 1;
            do {
                do {
                    low++;
                } while (list[low] < pivot && low < right);
                do {
                    high--;
                } while (list[high] > pivot && high > left);
                Console.WriteLine("low = " + low + " high = " + high);
                if (low < high)
                {
                    temp = list[high];
                    list[high] = list[low];
                    list[low] = temp;
                }
                print(list);
            } while (low < high);
            Console.WriteLine("END");
            temp = list[high];
            list[high] = list[left];
            list[left] = temp;
            return high;
        }
        static void quick_sort(int[] list, int left, int right)
        {
            if (left < right)
            {
                int q = partition(list, left, right);
                quick_sort(list, left, q - 1);
                quick_sort(list, q + 1, right);
            }
        }
        static void Main(string[] args)
        {
            int[] list = { 5, 3, 8, 4, 9, 1, 6, 2, 7 };

            Console.WriteLine("정렬 전 : ");
            print(list);

            quick_sort(list, 0, list.Length - 1);

            Console.WriteLine("정렬 후 : ");
            print(list);
        }
    }
}
