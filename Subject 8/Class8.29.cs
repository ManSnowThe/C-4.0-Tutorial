// Использовать модификатор static.
using System;

namespace ca2
{
    class StaticDemo
    {
        // Переменная типа static.
        public static int Val = 100;

        // Метод типа static.
        public static int ValDiv2()
        {
            return Val / 2;
        }
    }
    class SDemo
    {
        static void Main()
        {
            Console.WriteLine("Исходное значение переменной " +
            "StaticDemo.Val равно " + StaticDemo.Val);

            StaticDemo.Val = 8;

            Console.WriteLine("Текущее значение переменной" +
            "StaticDemo.Val равно " + StaticDemo.Val);

            Console.WriteLine("StaticDemo.ValDiv2(): " + StaticDemo.ValDiv2());
        }
    }
}
