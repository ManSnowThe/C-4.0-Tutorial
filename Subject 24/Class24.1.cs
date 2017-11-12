// Создать и запустить задачу на исполнение.
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ca2
{
    class DemoTask
    {
        // Метод выполняемый в качестве задачи.
        static void MyTask()
        {
            Console.WriteLine("MyTask() запущен");

            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе MyTask(), подсчет равен " + count);
            }
            Console.WriteLine("MyTask завершен.");
        }
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");

            // Сконструировать объект задачи.
            Task tsk = new Task(MyTask);

            // Запустить задачу на исполнение.
            tsk.Start();

            // Метод Main() активный до завершения метода MyTask().
            for(int i=0; i<60; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            Console.WriteLine("Основной поток завершен.");
        }
    }
}
