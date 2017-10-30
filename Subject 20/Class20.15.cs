// Продемонстрировать применение типа dynamic.
using System;
using System.Globalization;

namespace ca2
{
    class DynDemo
    {
        static void Main()
        {
            // Объявить две динамические переменные.
            dynamic str;
            dynamic val;

            // Поддерживается неявное преобразование в динамические типы.
            // Поэтому следующие присваивания вполне допустимы.
            str = "это строка";
            val = 10;

            Console.WriteLine("Переменная str содержит: " + str);
            Console.WriteLine("Переменная val содержит: " + val + '\n');

            str = str.ToUpper(CultureInfo.CurrentCulture);
            Console.WriteLine("Переменная str теперь содержит: " + str);

            val = val + 2;
            Console.WriteLine("Переменная val теперь содержит: " + val + '\n');

            string str2 = str.ToLower(CultureInfo.CurrentCulture);
            Console.WriteLine("Переменная str2 содержит: " + str2);

            // Поддерживаются неявные преобразования из динамических типов.
            int x = val * 2;
            Console.WriteLine("Переменная x содержит: " + x);
        }
    }
}
