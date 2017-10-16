// Продемонстрировать применение статического класса.
using System;

namespace ca2
{
    static class NumericFn
    {
        // Возвратить обратное числовое значение.
        static public double Reciprocal(double num)
        {
            return 1 / num;
        }
        // Возвратить дробную часть числового значения.
        static public double FracPart(double num)
        {
            return num - (int)num;
        }
        // Возвратить логическое значение true, если числовое
        // значение переменной num окажется четным.
        static public bool IsEven(double num)
        {
            return (num % 2) == 0 ? true : false;
        }
        // Возвратить логическое значение true, если числовое
        // значение переменной num окажется нечетным.
        static public bool IsOdd(double num)
        {
            return !IsEven(num);
        }
    }
    class StaticClassDemo
    {
        static void Main()
        {
            Console.WriteLine("Обратная величина числа 5 равна " + NumericFn.Reciprocal(5.0));
            Console.WriteLine("Дробная часть числа 4.234 равна " + NumericFn.FracPart(4.234));

            if (NumericFn.IsEven(10))
                Console.WriteLine("10 — четное число.");

            if (NumericFn.IsOdd(5))
                Console.WriteLine("5 — нечетное число.");

            // Далее следует попытка создать экземпляр объекта класса NumericFn,
            // что может стать причиной появления ошибки.
            
            // NumericFn ob = new NumericFn(); // Ошибка!
        }
    }
}
