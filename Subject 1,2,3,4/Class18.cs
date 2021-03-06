﻿//Пример укороченных логических операций
using System;

namespace ca2
{
    class Scops
    {
        static void Main()
        {
            int n, d;
            n = 10;
            d = 2;
            if (d != 0 && (n % d) == 0) Console.WriteLine(n + " делится нацело на " + d);
            d = 0; // задать нулевое значение переменной d
                   // d равно нулю, поэтому второй операнд не вычисляется
            if (d != 0 && (n % d) == 0)
                Console.WriteLine(n + " делится нацело на " + d);
            // Если теперь попытаться сделать то же самое без укороченного
            // логического оператора, то возникнет ошибка из-за деления на нуль.
            if (d != 0 & (n % d) == 0)
                Console.WriteLine(n + " делится нацело на " + d);

        }
    }
}
