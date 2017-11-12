// Продемонстрировать продолжение задачи.
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ca2
{
    class ContinuationDemo
    {
        // Метод, исполняемый как задача.
        static void MyTask()
        {
            Console.WriteLine("MyTask() запущен");

            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе MyTask() подсчет равен " + count);
            }
            Console.WriteLine("MyTask завершен");
        }
        // Метод, исполняемый как продолжение задачи.
        static void ContTask(Task t)
        {
            Console.WriteLine("Продолжение запущено");

            for (int count = 0; count < 5; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В продолжении подсчет равен " + count);
            }
            Console.WriteLine("Продолжение завершено");
        }
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");
            
            // Сконструировать объект первой задачи.
            Task tsk = new Task(MyTask);
            
            // А теперь создать продолжение задачи.
            Task taskCont = tsk.ContinueWith(ContTask);

            
            // В данном случае в качестве продолжения задачи применяется лямбда-выражение.
            /*
            Task taskCont = tsk.ContinueWith((first) =>
            {
                Console.WriteLine("Продолжение запущено");
                for (int count = 0; count < 5; count++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("В продолжении подсчет равен " + count);
                }
                Console.WriteLine("Продолжение завершено");
            } );
            */

            // Начать последовательность задач.
            tsk.Start();
            
            // Ожидать завершения продолжения.
            taskCont.Wait();

            tsk.Dispose();
            taskCont.Dispose();

            Console.WriteLine("Основной поток завершен.");
        }
    }
}
