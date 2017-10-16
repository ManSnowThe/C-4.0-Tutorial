// Продемонстрировать применение анонимного метода, принимающего аргумент.
using System;

namespace ca2
{
    // Обратите внимание на то, что теперь у делегата CountIt имеется параметр.
    delegate void CountIt(int end);
    class AnonMethDemo2
    {
        static void Main()
        {
            // Здесь конечное значение для подсчета передается анонимному методу.
            CountIt count = delegate (int end)
            {
                for (int i = 0; i <= end; i++)
                    Console.WriteLine(i);
            };

            count(3);
            Console.WriteLine();
            count(5);
        }
    }
}
