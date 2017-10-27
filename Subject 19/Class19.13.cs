// Использовать оператор let в месте с вложенным оператором from.
using System;
using System.Linq;

namespace ca2
{
    class LetDemo
    {
        static void Main()
        {
            string[] strs = { "alpha", "beta", "gamma" };

            // Сформировать запрос на получение символов, возвращаемых из
            // строк в отсортированной последовательности. Обратите внимание
            // на применение вложенного оператора from.
            var chrs = from str in strs
                       let chrArray = str.ToCharArray()
                       from ch in chrArray
                       orderby ch
                       select ch;

            Console.WriteLine("Отдельные символы, отсортированные по порядку:");

            // Выполнить запрос и вывести его результаты.
            foreach (char c in chrs)
                Console.Write(c + " ");

            Console.WriteLine();
        }
    }
}
