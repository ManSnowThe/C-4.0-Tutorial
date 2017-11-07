// Использовать событийный объект, устанавливаемый
// в исходное состояние вручную.
using System;
using System.Threading;

namespace ca2
{
    // Этот поток уведомляет о том, что событие передано его конструктору.
    class MyThread
    {
        public Thread Thrd;
        ManualResetEvent mre;

        public MyThread(string name, ManualResetEvent evt)
        {
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            mre = evt;
            Thrd.Start();
        }
        // Точка входа в поток.
        void Run()
        {
            Console.WriteLine("Внутри потока " + Thrd.Name);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Thrd.Name);
                Thread.Sleep(500);
            }
            Console.WriteLine(Thrd.Name + " завершен!");

            // Уведомить о событии.
            mre.Set();
        }
    }
    class ManualEventDemo
    {
        static void Main()
        {
            ManualResetEvent evtObj = new ManualResetEvent(false);

            MyThread mt1 = new MyThread("Событийный Поток 1", evtObj);

            Console.WriteLine("Основной поток ожидает событие.");

            // Ожидать уведомления о событии.
            evtObj.WaitOne();

            Console.WriteLine("Основной поток получил уведомление о событии от первого потока.");

            // Установить событийный объект в исходное состояние.
            evtObj.Reset();

            mt1 = new MyThread("Событийный Поток 2", evtObj);

            // Ожидать уведомления о событии.
            evtObj.WaitOne();

            Console.WriteLine("Основной поток получил уведомление о событии от второго потока.");
        }
    }
}
