// Использовать метод экземпляра в качестве задачи.
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ca2
{
    class MyClass
    {
        // Метод выполняемый в качестве задачи.
        public void MyTask()
        {
            Console.WriteLine("MyTask() запущен");

            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);
                Console.WriteLine("В методе MyTask(), подсчет равен " + count);
            }
            Console.WriteLine("MyTask завершен.");
        }
    }
    class DemoTask
    {
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");
            
            // Сконструировать объект типа MyClass.
            MyClass mc = new MyClass();

            // Сконструировать объект задачи для метода mc.MyTask().
            Task tsk = new Task(mc.MyTask);

            // Запустить задачу на исполнение.
            tsk.Start();

            // Метод Main() активный до завершения метода MyTask().
            for (int i = 0; i < 60; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            Console.WriteLine("Основной поток завершен.");
        }
    }
}
