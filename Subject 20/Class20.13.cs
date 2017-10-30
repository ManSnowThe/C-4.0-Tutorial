// Применение оператора ??
using System;

namespace ca2
{
    class NullableDemo2
    {
        // Возвратить нулевой остаток.        static double GetZeroBal()
        {
            Console.WriteLine("В методе GetZeroBal().");
            return 0.0;
        }
        static void Main()
        {
            double? balance = 123.75;
            double currentBalance;

            // Здесь метод GetZeroBal() не вызывается, поскольку
            // переменная balance содержит конкретное значение.
            currentBalance = balance ?? GetZeroBal();

            Console.WriteLine(currentBalance);
        }
    }
}
