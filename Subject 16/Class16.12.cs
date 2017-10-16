// Использовать модификатор доступа internal.using System;

namespace ca2
{
    class InternalTest
    {
        internal int x;
    }
    class InternalDemo
    {
        static void Main()
        {
            InternalTest ob = new InternalTest();

            ob.x = 10; // доступно, потому что находится в том же файле

            Console.WriteLine("Значение ob.x: " + ob.x);
        }
    }
}
