// Применить поразрядный оператор И, чтобы сделать число четным.

using System;

namespace ca2
{
    class MakeEven
    {
        static void Main()
        {
            ushort num;
            ushort i;

            for (i = 1; i <= 10; i++)
            {
                num = i;

                Console.WriteLine("num: " + num);

                num = (ushort)(num & 0xFFFE);

                Console.WriteLine("num после сброса младшего разряда: " + num + "\n");
            }
        }
    }
}