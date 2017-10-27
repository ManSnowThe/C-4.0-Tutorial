// Использовать методы запроса для формирования простого запроса.
// Это переделанный вариант первого примера программы из настоящей главы.using System;
using System.Linq;

namespace ca2
{
    class SimpQuery
    {
        static void Main()
        {
            int[] nums = { 1, -2, 3, 0, -4, 5 };
            // Использовать методы Where() и Select() для
            // формирования простого запроса.
            var posNums = nums.Where(n => n > 0).OrderByDescending(j => j).Select(r => r * 10);

            Console.Write("Положительные значения из массива nums: ");

            // Выполнить запрос и вывести его результаты.
            foreach (int i in posNums)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
