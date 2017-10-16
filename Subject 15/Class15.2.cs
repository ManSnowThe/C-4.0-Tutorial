// Групповое преобразование методов в делегате.
using System;

namespace ca2
{
    // Объявить тип делегата.
    delegate string StrMod(string str);
    class DelegateTest
    {
        // Заменить пробелы дефисами.
        static string ReplaceSpaces(string s)
        {
            Console.WriteLine("Замена пробелов дефисами");
            return s.Replace(' ', '-');
        }

        // Удалить пробелы.
        static string RemoveSpaces(string s)
        {
            string temp = "";
            int i;

            Console.WriteLine("Удаление пробелов.");
            for (i = 0; i < s.Length; i++)
                if (s[i] != ' ') temp += s[i];
            return temp;
        }

        // Обратить строку.
        static string Reverse(string s)
        {
            string temp = "";
            int i, j;

            Console.WriteLine("Обращение строки.");
            for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
                temp += s[i];
            return temp;
        }
        static void Main()
        {
            // Сконструировать делегат, используя групповое преобразование методов.
            StrMod strOp = ReplaceSpaces; // использовать групповое преобразование методов
            string str;

            // Вызвать методы с помощью делегата.
            str = strOp("Это просто тест.");
            Console.WriteLine("Результирующая строка: " + str);

            Console.WriteLine();

            strOp = RemoveSpaces; // использовать групповое преобразование методов
            str = strOp("Это простой тест.");
            Console.WriteLine("Результирующая строка: " + str);

            Console.WriteLine();

            strOp = Reverse; // использовать групповое преобразование методов
            str = strOp("Это простой тест.");
            Console.WriteLine("Результирующая строка: " + str);
        }
    }
}