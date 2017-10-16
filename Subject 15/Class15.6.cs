// Продемонстрировать применение анонимного метода.
using System;

namespace ca2
{
    // Объявить тип делегата.
    delegate void CountIt();
    class AnonMethDemo
    {
        static void Main()
        {
            // Далее следует код для подсчета чисел, передаваемый делегату
            // в качестве анонимного метода.
            CountIt count = delegate
            {
                // Это кодовый блок передается делегату.
                for (int i = 0; i <= 5; i++)
                    Console.WriteLine(i);
            }; // Обратите внимание на точку с запятой.
            count();
        }
    }
}
