// Продемонстрировать применение анонимного метода, возвращающего значение.
using System;

namespace ca2
{
    // Этот делегат возвращает значение.
    delegate int CountIt(int end);
    class AnonMethDemo3
    {
        static void Main()
        {
            int result;

            // Здесь конечное значение для подсчета передается анонимному методу.
            // А возвращается сумма подсчитанных чисел.
            CountIt count = delegate (int end)
            {
                int sum = 0;

                for (int i = 0; i <= end; i++)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                return sum; // возвратить значение из анонимного метода
            };

            result = count(3);
            Console.WriteLine("Сумма 3 равна " + result);
            Console.WriteLine();

            result = count(5);
            Console.WriteLine("Сумма 5 равна " + result);
        }
    }
}
