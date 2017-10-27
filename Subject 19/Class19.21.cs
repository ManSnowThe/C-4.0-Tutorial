// Использовать метод Average() вместе с синтаксисом запросов.
using System;
using System.Linq;

namespace ca2
{
    class ExtMethods2
    {
        static void Main()
        {
            int[] nums = { 1, 2, 4, 8, 6, 9, 10, 3, 6, 7 };

            var ltAvg = from n in nums
                        let x = nums.Average()
                        where n < x
                        select n;

            Console.WriteLine("Среднее значение равно " + nums.Average());
            Console.Write("Значения меньше среднего: ");

            // Выполнить запрос и вывести его результаты.
            foreach (int i in ltAvg)
                Console.Write(i + " ");

            Console.WriteLine();
        }
    }
}
