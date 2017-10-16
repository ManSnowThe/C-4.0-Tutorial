// Продемонстрировать применение ключевых слов checked
// и unchecked в блоке операторов.
using System;

namespace ca2
{
    class CheckedBlocks
    {
        static void Main()
        {
            byte a, b;
            byte result;

            a = 127;
            b = 127;

            try
            {
                unchecked
                {
                    a = 127;
                    b = 127;
                    result = unchecked((byte)(a * b));
                    Console.WriteLine("Непроверенный на переполнение результат: " + result);
                    a = 125;
                    b = 5;
                    result = unchecked((byte)(a * b));
                    Console.WriteLine("Непроверенный на переполнение результат: " + result);
                }
                checked
                {
                    a = 2;
                    b = 7;
                    result = checked((byte)(a * b)); // верно
                    Console.WriteLine("Проверенный на переполнение результат: " + result);

                    a = 127;
                    b = 127;
                    result = checked((byte)(a * b)); // эта операция приводит к исключительной ситуации
                    Console.WriteLine("Проверенный на переполнение результат: " + result); // не подлежит выполнению
                }
            }
            catch (OverflowException exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}
