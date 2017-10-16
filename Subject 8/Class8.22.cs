// Продемонстрировать необязательные аргументы.
using System;

namespace ca2
{
    class OptionArgDemo
    {
        static void OptArgMeth(int alpha, int beta = 10, int gamma = 20)
        {
            Console.WriteLine("Это аргументы alpha, beta, gamma: " + alpha + " " + beta + " " + gamma);
        }
        static void Main()
        {
            // Передать все аргументы явным образом.
            OptArgMeth(1, 2, 3);

            // Сделать аргумент gamma необязательным.
            OptArgMeth(1, 2);

            // Сделать оба аргумента beta и gamma необязательными.
            OptArgMeth(1);
        }
    }
}
