// Организовать вывод в потоки Console.Out и Console.Error.
using System;

namespace ca2
{
    class ErrOut
    {
        static void Main()
        {
            int a = 10, b = 0;
            int result;

            Console.Out.WriteLine("Деление на нуль приведет к исключительной ситуации.");

            try
            {
                result = a / b; // сгенерировать исключение при попытки деления на нуль
            }
            catch (DivideByZeroException exc)
            {
                Console.Error.WriteLine(exc.Message);
            }
        }
    }
}
