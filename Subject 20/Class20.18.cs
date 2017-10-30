// Продемонстрировать применение оператора using.
using System;
using System.IO;

namespace ca2
{
    class UsingDemo
    {
        static void Main()
        {
            try
            {
                StreamReader sr = new StreamReader("test.txt");

                // Использовать объект в операторе using.
                using (sr)
                {
                    // ...
                }
            }
            catch(IOException exc)
            {
                // ...
            }
            try
            {
                // Создать объект класса StreamReader в операторе using.
                using (StreamReader sr2 = new StreamReader("test.txt"))
                {
                    // ...
                }
            }
            catch(IOException exc)
            {
                // ...
            }
        }
    }
}
