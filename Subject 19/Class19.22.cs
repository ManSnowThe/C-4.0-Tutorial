// Использовать режим немедленного выполнения запроса.
using System;
using System.Linq;

namespace ca2
{
    class ImmediateExec
    {
        static void Main()
        {
            int[] nums = { 1, -2, 3, 0, -4, 5 };

            // Сформировать запрос на получение количества
            // положительных значений в массиве nums.
            int len = (from n in nums
                       where n > 0
                       select n).Count();
            // int len = posNums.Count(); // запрос выполняется здесь

            Console.WriteLine("Количество положительных значений в массиве nums: " + len);
        }
    }
}
