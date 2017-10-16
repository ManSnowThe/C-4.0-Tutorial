// Использовать необязательный аргумент, чтобы упростить вызов метода.
using System;


namespace ca2
{
    class UseOptArgs
    {
        // Вывести на экран символьную строку полностью или частично.
        static void Display(string str, int start=0, int stop = -1)
        {
            if (stop < 0)
                stop = str.Length;

            // Проверить условие выхода за заданные пределы.
            if (stop > str.Length | start > stop | stop < 0)
                return;

            for (int i = start; i < stop; i++)
                Console.Write(str[i]);

            Console.WriteLine();
        }
        static void Main()
        {
            Display("это простой тест");
            Display("это простой тест", 12);
            Display("это простой тест", 4, 14);
        }
    }
}
