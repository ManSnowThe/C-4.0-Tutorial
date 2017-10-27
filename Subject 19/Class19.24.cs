// Создать и использовать ряд методов расширения.
using System;
using System.Globalization;

namespace ca2
{
    static class MyExtMeths
    {
        // Возвратить обратную величину числового значения типа double.
        public static double Reciprocal(this double v)
        {
            return 1.0 / v;
        }
        // Изменить на обратный регистр букв в символьной
        // строке и возвратить результат.
        public static string RevCase(this string str)
        {
            string temp = "";

            foreach(char ch in str)
            {
                if (Char.IsLower(ch)) temp += Char.ToUpper(ch, CultureInfo.CurrentCulture);
                else temp += Char.ToLower(ch, CultureInfo.CurrentCulture);
            }
            return temp;
        }
        // Возвратить абсолютное значение выражения n / d.
        public static double AbsDivideBy(this double n, double d)
        {
            return Math.Abs(n / d);
        }
    }
    class ExtDemo
    {
        static void Main()
        {
            double val = 8.0;
            string str = "Alpha Beta Gamma";

            // Вызвать метод расширения Reciprocal().
            Console.WriteLine("Обратная величина {0} равна {1}", val, val.Reciprocal());

            // Вызвать метод расширения RevCase().
            Console.WriteLine(str + " после смены регистра: " + str.RevCase());

            // Использовать метод расширения AbsDivideBy().
            Console.WriteLine("Результат вызова метода val.AbsDivideBy(-2): " + val.AbsDivideBy(-2));
        }
    }
}
