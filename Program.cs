using System;

namespace NoughtsAndCrosses
{
    class Program
    {
        static int[] a;
        const int Sz = 3;

        static void Draw()
        {
            for (int i = 0; i < Sz; i++)
            {
                for (int j = 0; j < Sz; j++)
                {
                    switch (a[i * Sz + j])
                    {
                        case -1:
                            {
                                Console.Write('X');
                                break;
                            }
                        case 0:
                            {
                                Console.Write('O');
                                break;
                            }
                        default:
                            {
                                Console.Write(a[i * Sz + j]);
                                break;
                            }
                    }
                }
                Console.WriteLine();
            }
        }

        static void Turn(bool IsX)
        {
            int h = 0;
            do
            {
                if (int.TryParse(Console.ReadLine(), out h) && h > 0 && h <= Sz * Sz && a[h - 1] > 0)
                {
                    a[h - 1] = IsX ? -1 : 0;
                }
                else
                {
                    h = 0;
                }
            }
            while (h == 0);
        }

        static void Main()
        {
            a = new int[Sz * Sz] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int left = Sz * Sz;
            bool IsX = false;
            Draw();
            while (left > 0)
            {
                Turn(IsX);
                Draw();
                IsX = !IsX;
                left--;
            }
            Console.ReadKey();
        }
    }
}