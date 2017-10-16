// Делегаты могут ссылаться и на методы экземпляра.
using System;

namespace ca2
{
    // Объявить тип делегата.
    delegate string StrMod(string str);
    class StringOps
    {
        // Заменить пробелы дефисами.
        public string ReplaceSpaces(string s)
        {
            Console.WriteLine("Замена пробелов дефисами.");
            return s.Replace(' ', '-');
        }

        // Удалить пробелы.
        public string RemoveSpaces(string s)
        {
            string temp = "";
            int i;
            Console.WriteLine("Удаление пробелов.");
            for (i = 0; i < s.Length; i++)
                if (s[i] != ' ') temp += s[i];
            return temp;
        }
        // Обратить строку.
        public string Reverse(string s)
        {
            string temp = "";
            int i, j;
            for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
                temp += s[i];
            return temp;
        }
    }
    class DelegateTest
    {
        static void Main()
        {
            StringOps so = new StringOps(); // создать экземпляр объекта класса StringOps

            // Инициализировать делегат.
            string str;
            StrMod strOp = so.ReplaceSpaces;

            // Вызвать методы с помощью делегатов.
            str = strOp("Это простой тест.");
            Console.WriteLine("Результирующая строка: " + str);
            Console.WriteLine();
            strOp = so.RemoveSpaces;
            str = strOp("Это простой тест.");
            Console.WriteLine("Результирующая строка: " + str);
            Console.WriteLine();

            strOp = so.Reverse;
            str = strOp("Это простой тест.");
            Console.WriteLine("Результирующая строка: " + str);
        }
    }
}
