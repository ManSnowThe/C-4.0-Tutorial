// Продемонстрировать неявно типизированный ступенчатый массив.
using System;

namespace ca2
{
    class jagged
    {
        static void Main()
        {
            var jagged = new[]
            {
                new [] { 1, 2, 3, 4 },
                new [] { 9, 8, 7},
                new [] { 11, 12, 13, 14, 15}
            };
            for (int i=0; i<jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                    Console.Write(jagged[i][j] + " ");

                Console.WriteLine();
            }
        }
    }
}
