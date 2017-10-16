using System;
using System.IO;

namespace ca2
{
    class abc
    {
        static void Main()
        {

            FileStream fin;
            try {
                fin = new FileStream("test", FileMode.Open, FileAccess.Read);
            }
            catch (IOException exc) { // перехватить все исключения, связанные с вводом-выводом
                Console.WriteLine(exc.Message);
                // Обработать ошибку.
            }
            catch (Exception exc)
            { // перехватить любое другое исключение.
                Console.WriteLine(exc.Message);
                // Обработать ошибку, если это возможно.
                // Еще раз сгенерировать необрабатываемые исключения.
            }
        }
    }
}