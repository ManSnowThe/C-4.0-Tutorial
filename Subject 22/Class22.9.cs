// Пример вставки, замены и удаления строк.
using System;

namespace ca2
{
    class InsRepRevDemo
    {
        static void Main()
        {
            string str = "Это тест";

            Console.WriteLine("Исходная строка: " + str);

            // Вставить строку.
            str = str.Insert(4, "простой ");
            Console.WriteLine(str);

            // Заменить строку.
            str = str.Replace("простой", "непростой");
            Console.WriteLine(str);

            // Заменить символы в строке.
            str = str.Replace('т', 'Х');
            Console.WriteLine(str);

            // Удалить строку.
            str = str.Remove(4, 5);
            Console.WriteLine(str);
        }
    }
}
