// Поиск в массиве с помощью оператора цикла foreach.
using System;

namespace ca2
{
    class Search
    {
        static void Main()
        {
            int[] nums = new int[10];
            int val;
            bool found = false;

            // Задать первоначальные значения элементов массива nums.
            for (int i = 0; i < 10; i++)
                nums[i] = i;

            val = 5;
            // Использовать цикл foreach для поиска заданного
            // значения в массиве nums.
            foreach (int x in nums)
            {
                if (x == val)
                {
                    found = true;
                    break;
                }

            }
            if (found)
                Console.WriteLine("Значение найдено!");
        }
    }
}
