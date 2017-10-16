﻿// Продемонстрировать применение ключевых слов checked и unchecked.
using System;

namespace ca2
{
    class CheckedDemo
    {
        static void Main()
        {
            byte a, b;
            byte result;

            a = 127;
            b = 127;

            try
            {
                result = unchecked((byte)(a * b));
                Console.WriteLine("Непроверенный на переполнение результат: " + result);

                result = checked((byte)(a * b)); // эта операция приводит к исключительной ситуации
                Console.WriteLine("Проверенный на переполнение результат: " + result); // не подлежит выполнению
            }
            catch (OverflowException exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}
