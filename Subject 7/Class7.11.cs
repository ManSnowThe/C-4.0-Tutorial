// Использовать оператор цикла foreach.
using System;

namespace ca2
{
    class ForEachDemo
    {
        static void Main()
        {
            int sum = 0;
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
                nums[i] = i;

            // Использовать цикл foreach для вывода значений
            // элементов массива и подсчета их суммы.
            foreach(int x in nums)
            {
                Console.WriteLine("Значение элемента равно: " + x);
                sum += x;
                if (x == 4) break;
            }
            Console.WriteLine("Сумма первых 5 элементов равна: " + sum);
            }
        }
    }
