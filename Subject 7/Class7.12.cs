// Использовать оператор цикла foreach для обращения к двумерному массиву.
using System;

namespace ca2
{
    class ForEachDemo2
    {
        static void Main()
        {
            int sum = 0;
            int[,] nums = new int[3, 5];

            // Задать первоначальные значения элементов массива nums.
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 5; j++)
                    nums[i, j] = (i + 1) * (j + 1);

            // Использовать цикл foreach для вывода значений
            // элементов массива и подсчета их суммы.
            foreach(int x in nums)
            {
                Console.WriteLine("Значение элемента равно: " + x);
                sum += x;
            }
            Console.WriteLine("Сумма равна: " + sum);
        }
    }
}
