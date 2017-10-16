using System;

namespace ca2
{
    class ScopeDemo
    {
        static void Main()
        {
            int x; // доступна для всего кода внутри метода Main
            x = 10;
            if (x == 10)
            {
                int y = 20;
                Console.WriteLine("x и y: " + x + " " + y);
                x = y * 2;
            }
            // у = 100; // Ошибка! Переменна у здесь недоступна.
            // А переменная х здесь по-прежнему доступна.

            Console.WriteLine("х равно " + x);

        }
    }
}