using System;

namespace Shell_sort_CSharp
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
            int[] x = { 30, 50, 7, 40, 88, 15, 44, 55, 22, 33, 77, 99, 11, 66, 1, 85 };

            int i, j;

            Console.Write("정렬 전: ");
            print(x);

            int D = x.Length;

            while (D != 1)
            {
                if (D % 2 == 0) D = D / 2 + 1;
                else D = D / 2;
                for (i = D; i < x.Length; i++)
                {
                    int box = x[i];
                    for (j = i - D; j >= 0; j -= D)
                    {
                        if (box > x[j]) break;
                        x[j + D] = x[j];
                    }
                    x[j + D] = box;
                }
            }

            Console.Write("정렬 후: ");
            print(x);
        }
    }
}
