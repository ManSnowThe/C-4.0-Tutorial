// Проиндексировать указатель как массив.
using System;

namespace ca2
{
    class PtrIndexDemo
    {
        unsafe static void Main()
        {
            int[] nums = new int[10];

            // Проиндексировать указатель.
            Console.WriteLine("Индексирование указателя как массива.");
            fixed(int* p = nums)
            {
                for (int i = 0; i < 10; i++)
                    p[i] = i; // индексировать указатель как массив

                for (int i = 0; i < 10; i++)
                    Console.WriteLine("p[{0}]: {1} ", i, p[i]);
            }

            // Использовать арифметические операции над указателями.
            Console.WriteLine("Применение арифметических операций над указателями.");
            fixed(int* p = nums)
            {
                for (int i = 0; i < 10; i++)
                    *(p + i) = i; // использовать арифметическую операцию над указателем

                for (int i = 0; i < 10; i++)
                    Console.WriteLine("*(p+{0}): {1} ", i, *(p + i));
            }
        }
    }
}
