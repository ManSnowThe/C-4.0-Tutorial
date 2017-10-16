// Продемонстрировать применение блочного лямбда-выражения.
using System;

namespace ca2
{
    // Делегат IntOp принимает один аргумент типа int
    // и возвращает результат типа int.
    delegate int IntOp(int end);
    class StatementLambdaDemo
    {
        static void Main()
        {
            // Блочное лямбда-выражение возвращает факториал
            // передаваемого ему значения.
            IntOp fact = n =>
            {
                int r = 1;
                for (int i = 1; i <= n; i++)
                    r = i * r;
                return r;
            };
            Console.WriteLine("Факториал 3 равен: " + fact(3));
            Console.WriteLine("Факториал 5 равен: " + fact(5));
        }
    }
}
