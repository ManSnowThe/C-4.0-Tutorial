// Отсортировать массив и найти в нем значение.
using System;

namespace ca2
{
    class SortDemo
    {
        static void Main()
        {
            int[] nums = { 5, 4, 6, 3, 14, 9, 8, 17, 1, 24, -1, 0 };

            // Отобразить исходный порядок следования.
            Console.Write("Исходный порядок следования: ");
            foreach (int i in nums)
                Console.Write(i + " ");

            Console.WriteLine();

            // Отсортировать массив.
            Array.Sort(nums);

            // Отобразить порядок следования после сортировки.
            Console.Write("Порядок следования после сортировки: ");
            foreach (int i in nums)
                Console.Write(i + " ");

            Console.WriteLine();

            // Найти значение 14.
            int idx = Array.BinarySearch(nums, 14);
            Console.WriteLine("Индекс элемента массива со значением 14: " + idx);
        }
    }
}
