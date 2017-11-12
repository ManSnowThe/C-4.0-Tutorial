// Применить метод Parallel.Invoke() для параллельного выполнения двух методов.
// В этой версии программы применяются лямбда-выражения.
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ca2
{
    class DemoParallel
    {
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");

            // Выполнить два анонимных метода, указываемых в лямбда-выражениях.
            Parallel.Invoke(() =>
            {
                Console.WriteLine("Выражение #1 запущено");

                for (int count = 0; count < 5; count++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("В выражении #1 подсчет равен " + count);
                }
                Console.WriteLine("Выражение #1 завершено");
            },
            () =>
            {
                Console.WriteLine("Выражение #2 запущено");
                for (int count = 0; count < 5; count++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("В выражении #2 подсчет равен " + count);
                }
                Console.WriteLine("Выражение #2 завершено");
            }
            );
            Console.WriteLine("Основной поток завершен.");
        }
    }
}
