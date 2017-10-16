// Применить поразрядный оператор И, чтобы определить,
// является ли число нечетным.

using System;

namespace ca2
{
    class IsOdd
    {
        static void Main()
        {
            ushort num;
            num = 10;

            if ((num & 1) == 1) Console.WriteLine("Не выводится");

            num = 11;
            if ((num & 1) == 1) Console.WriteLine(num + " - нечетное число");
        }
    }
}