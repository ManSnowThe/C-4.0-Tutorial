// Пример простого дерева выражений.using System;
using System.Linq;
using System.Linq.Expressions;

namespace ca2
{
    class SimpleExpTree
    {
        static void Main()
        {
            // Представить лямбда-выражение в виде данных.
            Expression<Func<int, int, bool>> IsFactorExp = (n, d) => (d != 0) ? (n % d) == 0 : false;

            // Скомпилировать данные выражения в исполняемый код.
            Func<int, int, bool> IsFactor = IsFactorExp.Compile();

            // Выполнить выражение.
            if (IsFactor(10, 5))
                Console.WriteLine("Число 5 является множителем 10.");

            if (!IsFactor(10, 7))
                Console.WriteLine("Число 7 не является множителем 10.");

            Console.WriteLine();
        }
    }
}
