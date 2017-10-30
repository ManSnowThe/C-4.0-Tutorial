// Использовать модификатор fixed для получения
// указателя на начало строки.
using System;

namespace ca2
{
    class FixedString
    {
        unsafe static void Main()
        {
            string str = "это тест";

            // Получить указатель p на начало строки str.
            fixed(char* p = str)
            {
                // Вывести содержимое строки str по указателю р.
                for (int i = 0; p[i] != 0; i++)
                    Console.Write(p[i]);
            }
            Console.WriteLine();
        }
    }
}
