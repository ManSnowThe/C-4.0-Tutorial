using System;

namespace ca2
{
    class ifdemo
    {
        static void Main()
        {
            int a, b, c;

            a = 2;
            b = 3;

            if (a < b) Console.WriteLine("a меньше b");

            //Не подлежит выводу
            if (a == b) Console.WriteLine("Этого никто не увидит");

            Console.WriteLine();

            c = a - b; // c содежрит -1

            Console.WriteLine(c);
            if (c >= 0) Console.WriteLine("Значение c неотрицательно");
            if (c < 0) Console.WriteLine("Значение c отрицательно");

            Console.WriteLine();

            c = b - a; // c содержит 1

            Console.WriteLine(c);
            if (c >= 0) Console.WriteLine("Значение c неотрицательно");
            if (c < 0) Console.WriteLine("Значение c отрицательно");
        }
    }

}