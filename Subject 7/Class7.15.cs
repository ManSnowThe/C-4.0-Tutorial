// Некоторые операции со строками.
using System;
using System.Globalization;

namespace ca2
{
    class StrOps
    {
        static void Main()
        {
            string str1 = "Программировать в .NET лучше всего на С#.";
            string str2 = "Программировать в .NET лучше всего на С#.";
            string str3 = "Строки в C# весьма эффективны.";
            string strUp, strLow;
            int idx, result;

            Console.WriteLine("str1: " + str1);
            Console.WriteLine("Длина строки str1: " + str1.Length);

            // Создать варианты строки str1, набранные
            // прописными и строчными буквами.
            strLow = str1.ToLower(CultureInfo.CurrentCulture);
            strUp = str2.ToUpper(CultureInfo.CurrentCulture);
            Console.WriteLine("Вариант строки набранный строчными буквами:\n" + strLow);
            Console.WriteLine("Вариант строки набранный прописными буквами:\n" + strUp);

            Console.WriteLine();

            // Вывести строку str1 посимвольно.
            Console.WriteLine("Вывод строки str1 посимвольно.");
            for (int i = 0; i < str1.Length; i++)
                Console.Write(str1[i]);

            Console.WriteLine("\n");
            // Сравнить строки способом порядкового сравнения.
            if (str1 == str2)
                Console.WriteLine("str1==str2");
            else
                Console.WriteLine("str1!=str2");
            if (str1 == str3)
                Console.WriteLine("str1==str3");
            else
                Console.WriteLine("str1!=str3");

            // Сравнить строки с учетом культурной среды.
            result = string.Compare(str3, str1, StringComparison.CurrentCulture);
            if (result == 0)
                Console.WriteLine("Строки str1 и str3 равны");
            else if (result < 0)
                Console.WriteLine("str1 меньше str3");
            else
                Console.WriteLine("str1 больше str3");

            Console.WriteLine();

            // Присвоить новую строку переменной str2.
            str2 = "Один Два Три Один";

            // Поиск подстроки.
            idx = str2.IndexOf("Один", StringComparison.Ordinal);
            Console.WriteLine("Индекс первого вхождения подстроки <Один>: " + idx);
            idx = str2.LastIndexOf("Один", StringComparison.Ordinal);
            Console.WriteLine("Индекс последнего вхождения подстроки <Один>: " + idx);



        }
    }
}
