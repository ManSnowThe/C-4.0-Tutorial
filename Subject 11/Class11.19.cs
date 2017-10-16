// Пример упаковки при передаче значения методу.
using System;

namespace ca2
{
    class BoxingDemo
    {
        static void Main()
        {
            int x;
            x = 10;
            Console.WriteLine("Значение x равно: " + x);
            // значение переменной x автоматически упаковывается
            // когда оно передается методу Sqr().
            x = BoxingDemo.Sqr(x);
            Console.WriteLine("Значение x в квадрате равно: " + x);
        }
        static int Sqr(object о)
        {
            return (int)о * (int)о;
        }
    }
}
