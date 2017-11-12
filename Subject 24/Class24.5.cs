// Применить лямбда-выражение в качестве задачи.
using System;
using System.Threading;
using System.Threading.Tasks;
namespace ca2
{
    class DemoLambdaTask
    {
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");

            // Далее лямбда-выражение используется для определения задачи.
            Task tsk = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Задача запущена");

                for (int count = 0; count < 10; count++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Подсчет в задаче равен " + count);
                }
                Console.WriteLine("Задача завершена.");
            });

            // Ожидать завершения задачи tsk.
            tsk.Wait();

            // Освободить задачу tsk.
            tsk.Dispose();

            Console.WriteLine("Основной поток завершен.");
        }
    }
}
