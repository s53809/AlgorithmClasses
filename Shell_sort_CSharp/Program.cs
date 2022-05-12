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
            int[] x = { 10, 8, 6, 20, 4, 3, 22, 1, 0, 15, 16 };

            int i, j;

            Console.Write("정렬 전: ");
            print(x);

            int D = x.Length;

            while (D != 1)
            {
                if (D % 2 != 0) D = D / 2 + 1;
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
                Console.Write(D + " | ");
                print(x);
            }

            Console.Write("정렬 후: ");
            print(x);
        }
    }
}
