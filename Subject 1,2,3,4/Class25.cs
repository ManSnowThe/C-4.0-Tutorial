//Продемонстрировать применение операторов сдвига

using System;

namespace ca2
{
    class ShiftDemo
    {
        static void Main()
        {
            int val = 1;
            for(int i=0; i < 8; i++)
            {
                for (int t=128; t>0; t = t / 2)
                {
                    if ((val & t) != 0) Console.Write("1 ");
                    if ((val & t) == 0) Console.Write("0 ");
                }
                Console.WriteLine();
                val = val << 1; // сдвиг влево
            }
            Console.WriteLine();
            val = 128;
            for (int i = 0; i < 8; i++)
            {
                for (int t = 128; t > 0; t = t / 2)
                {
                    if ((val & t) != 0) Console.Write("1 ");
                    if ((val & t) == 0) Console.Write("0 ");
                }
                Console.WriteLine();
                val = val >> 1; // сдвиг вправо
            }
        }
    }
}