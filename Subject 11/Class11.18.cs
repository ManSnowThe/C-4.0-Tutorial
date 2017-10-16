// Простой пример упаковки и распаковки.
using System;

namespace ca2
{
    class BoxingDemo
    {
        static void Main()
        {
            int x;
            object obj;

            x = 10;
            obj = x;  // упаковать значение переменной х в объект

            int y = (int)obj;  // распаковать значение из объекта, доступного по
                               // ссылке obj, в переменную типа int
            Console.WriteLine(y);
        }
    }
}
