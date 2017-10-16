//Разделить только на четные, ненулевые значения

using System;

namespace ca2
{
    class NoZeroDiv2
    {
        static void Main()
        {
            for (int i = -5; i < 6; i++)
                if (i != 0 ? (i % 2 == 0) : false)
                    Console.WriteLine("100 / " + i + " равно " + 100 / i);
        }
    }
}