// Продемонстрировать применение предикатного делегата.using System;

namespace ca2
{
    class PredDemo
    {
        // Предикатный метод, возвращающий логическое значение true,
        // если значение переменной v оказывается отрицательным.
        static bool IsNeg(int v)
        {
            if (v < 0) return true;
            return false;
        }
        static void Main()
        {
            int[] nums = { 1, 4, -1, 5, -9 };
            Console.Write("Содержимое массива nums: ");
            foreach (int i in nums)
                Console.Write(i + " ");
            Console.WriteLine();

            // Сначала проверить, содержит ли массив nums отрицательное значение.
            if (Array.Exists(nums, PredDemo.IsNeg))
            {
                Console.WriteLine("Массив nums содержит отрицательное значение.");

                // Затем найти первое отрицательное значение в массиве.
                int x = Array.Find(nums, PredDemo.IsNeg);
                Console.WriteLine("Первое отрицательное значение: " + x);
            }
            else
                Console.WriteLine("В массиве nums отсутствуют отрицательные значения.");
        }
    }
}
