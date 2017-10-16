//Преобразовать четные числа в нечетные поразрядным оператором ИЛИ

using System;

namespace ca2
{
    class MakeOdd
    {
        static void Main()
        {
            ushort num;
            ushort i;

            for(i=1; i<=10; i++)
            {
                num = i;
                Console.WriteLine("num: " + num);

                num = (ushort)(num | 1);
                Console.WriteLine("num после установки младшего разряда " + num + "\n");
            }
        }
    }
}