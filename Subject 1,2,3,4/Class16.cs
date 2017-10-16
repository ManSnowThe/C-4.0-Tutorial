// Продемонстрировать применение операторов
// отношения и логических операторов.

using System;

namespace ca2
{
    class RelLogOps
    {
        static void Main()
        {
            int i, j;
            bool b1, b2;

            i = 10;
            j = 11;

            Console.WriteLine(@"i = 10, j = 11, b1 = true, b2 = false
");

            if (i < j) Console.WriteLine("i < j");
            if (i <= j) Console.WriteLine("i <= j");
            if (i != j) Console.WriteLine("i != j");
            if (i == j) Console.WriteLine("Нельзя выполнить");
            if (i >= j) Console.WriteLine("Нельзя выполнить");
            if (i > j) Console.WriteLine("Нельзя выполнить");

            b1 = true;
            b2 = false;

            if (b1 & b2) Console.WriteLine("Нельзя выполнить");
            if (!(b1 & b2)) Console.WriteLine("!(b1 & b2) - true");
            if (b1 | b2) Console.WriteLine("(b1 | b2) - true");
            if (b1 ^ b2) Console.WriteLine("(b1 ^ b2) - true");
        }
    }
}