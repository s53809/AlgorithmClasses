using System;

namespace selection_sort_CSharp
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
        static void Main(string[] args)
        {
            int[] x = { 15, 12, 5, 16, 3 };

            int i, j;

            Console.Write("정렬 전: ");
            print(x);

            for (i = 1; i < x.Length; i++)
            {
                int box = x[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (box > x[j]) break;
                    x[j + 1] = x[j];
                }
                x[j + 1] = box;
            }

            Console.Write("정렬 후: ");
            print(x);
        }
    }
}
