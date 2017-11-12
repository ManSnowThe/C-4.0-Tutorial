// Применить метод Parallel.Invoke() для параллельного выполнения двух методов.
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ca2
{
    class DemoParallel
    {
        // Метод, исполняемый как задача.
        static void MyMeth()
        {
            Console.WriteLine("MyMeth запущен");

            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе MyMeth подсчет равен " + count);
            }
            Console.WriteLine("MyMeth завершен");
        }
        // Метод, исполняемый как задача.
        static void MyMeth2()
        {
            Console.WriteLine("MyMeth2 запущен");

            for(int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе MyMeth2 подсчет равен " + count);
            }
            Console.WriteLine("MyMeth2 завершен");
        }
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");

            // Выполнить параллельно два именованных метода.
            Parallel.Invoke(MyMeth, MyMeth2);

            Console.WriteLine("Основной поток завершен.");
        }
    }
}
