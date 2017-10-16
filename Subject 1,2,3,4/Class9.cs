//Буквальные строковые литералы

using System;

namespace ca2
{
    class literB
    {
        static void Main()
        {
            Console.WriteLine(@"Это буквальный
строковой литерал,
занимающий несколько строк.
");
            Console.WriteLine(@"А это вывод с табуляцией:
1  2  3  4
5  6  7  8
");
            Console.WriteLine(@"Отзыв программиста: ""Мне нравится программировать на C#.""");
        }
    }
}