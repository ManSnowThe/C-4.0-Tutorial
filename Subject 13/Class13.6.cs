// Сгенерировать исключение вручную.
using System;

namespace ca2
{
    class ThrowDemo
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("До генерирования исключения.");
                throw new DivideByZeroException();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Исключение перехвачено.");
            }
            Console.WriteLine("После пары операторов try/catch.");
        }
    }
}
