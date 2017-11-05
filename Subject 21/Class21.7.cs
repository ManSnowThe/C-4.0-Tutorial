// Обратить содержимое массива.
using System;

namespace ca2
{
    class ReverseDemo
    {
        static void Main()
        {
            int[] nums = { 1, 2, 3, 4, 5 };

            // Отобразить исходный порядок следования.
            Console.Write("Исходный порядок следования: ");
            foreach (int i in nums)
                Console.Write(i + " ");
            Console.WriteLine();

            // Обратить весь массив.
            Array.Reverse(nums);

            // Отобразить обратный порядок следования.
            Console.Write("Обратный порядок следования: ");
            foreach (int i in nums)
                Console.Write(i + " ");
            Console.WriteLine();

            // Обратить часть массива.
            Array.Reverse(nums, 1, 3);

            // Отобразить обратный порядок следования.
            Console.Write("Частично обращенный порядок следования: ");
            foreach (int i in nums)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
