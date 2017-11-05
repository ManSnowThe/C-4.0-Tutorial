// Продемонстрировать применение нескольких методов,
// определенных в структуре Char.
using System;
using System.Globalization;

namespace ca2
{
    class CharDemo
    {
        static void Main()
        {
            string str = "Это простой тест. $23";
            int i;
            for(i=0; i<str.Length; i++)
            {
                Console.Write(str[i] + " является");
                if (Char.IsDigit(str[i]))
                    Console.Write(" цифрой");
                if (Char.IsLetter(str[i]))
                    Console.Write(" буквой");
                if (Char.IsLower(str[i]))
                    Console.Write(" строчной");
                if (Char.IsUpper(str[i]))
                    Console.Write(" прописной");
                if (Char.IsSymbol(str[i]))
                    Console.Write(" символическим классом");
                if (Char.IsSeparator(str[i]))
                    Console.Write(" разделительным");
                if (Char.IsWhiteSpace(str[i]))
                    Console.Write(" пробелом");
                if (Char.IsPunctuation(str[i]))
                    Console.Write(" знаком препинания");

                Console.WriteLine();
            }
            Console.WriteLine("Исходная строка: " + str);

            // Преобразовать в прописные буквы.
            string newstr = "";
            for (i = 0; i < str.Length; i++)
                newstr += Char.ToUpper(str[i], CultureInfo.CurrentCulture);

            Console.WriteLine("После преобразования: " + newstr);
        }
    }
}
