﻿// Применить метод Wait().
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ca2
{
    class DemoTask
    {
        // Метод, исполняемый как задача.
        static void MyTask()
        {
            Console.WriteLine("MyTask() №" + Task.CurrentId + " запущен");

            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе MyTask() №" + Task.CurrentId + " подсчет равен " + count);
            }
            Console.WriteLine("MyTask №" + Task.CurrentId + " завершен");
        }
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");

            // Сконструировать объекты двух задач.
            Task tsk = new Task(MyTask);
            Task tsk2 = new Task(MyTask);

            // Запустить задачи на исполнение 
            tsk.Start();
            tsk2.Start();

            Console.WriteLine("Идентификатор задачи tsk: " + tsk.Id);
            Console.WriteLine("Идентификатор задачи tsk2: " + tsk2.Id);

            // Приостановить выполнение метода Main() до тех пор,
            // пока не завершатся обе задачи tsk и tsk2
            tsk.Wait();
            tsk2.Wait();
            // Task.WaitAll(tsk, tsk2);
            // Task.WaitAny(tsk, tsk2);

            Console.WriteLine("Основной поток завершен.");
        }
    }
}
