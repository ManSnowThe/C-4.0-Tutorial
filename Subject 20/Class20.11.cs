// Продемонстрировать применение обнуляемого типа.
using System;

namespace ca2
{
    class NullableDemo
    {
        static void Main()
        {
            int? count = null;

            if (count.HasValue)
                Console.WriteLine("Переменная count имеет следующее значение: " + count.Value);

            else
                Console.WriteLine("У переменной count отсутствует значение");

            count = 100;
            if(count.HasValue)
                Console.WriteLine("Переменная count имеет следующее значение: " + count.Value);
            else
                Console.WriteLine("У переменной count отсутствует значение");
        }
    }
}
