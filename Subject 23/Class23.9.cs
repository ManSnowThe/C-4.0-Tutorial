// Использовать методы Wait() и Pulse() для имитации тиканья часов.
using System;
using System.Threading;

namespace ca2
{
    class TickTock
    {
        object lockOn = new object();
        public void Tick(bool running)
        {
            lock (lockOn)
            {
                if (!running) // остановить часы
                {
                    Monitor.Pulse(lockOn); // уведомить любые ожидающие потоки
                    return;
                }
                Console.Write("тик ");
                Monitor.Pulse(lockOn); // разрешить выполнение метода Tock()
                Monitor.Wait(lockOn); // ожидать завершения метода Tock()
            }
        }
        public void Tock(bool running)
        {
            lock (lockOn)
            {
                if (!running) // остановить часы
                {
                    Monitor.Pulse(lockOn); // уведомить любые ожидающие потоки
                    return;
                }
                Console.WriteLine("так");
                Monitor.Pulse(lockOn); // разрешить выполнение метода Tick()
                Monitor.Wait(lockOn); // ожидать завершения метода Tick()
            }
        }
    }
    class MyThread
    {
        public Thread Thrd;
        TickTock ttob;

        // Сконструировать новый поток.
        public MyThread(string name, TickTock tt)
        {
            Thrd = new Thread(this.Run);
            ttob = tt;
            Thrd.Name = name;
            Thrd.Start();
        }
        // Начать выполнение нового потока.
        void Run()
        {
            if (Thrd.Name == "Tick")
            {
                for (int i = 0; i < 5; i++)
                    ttob.Tick(true);
                ttob.Tick(false);
            }
            else
            {
                for (int i = 0; i < 5; i++)
                    ttob.Tock(true);
                ttob.Tock(false);
            }
        }
    }
    class TickingClock
    {
        static void Main()
        {
            TickTock tt = new TickTock();
            MyThread mt1 = new MyThread("Tick", tt);
            MyThread mt2 = new MyThread("Tock", tt);

            mt1.Thrd.Join();
            mt2.Thrd.Join();

            Console.WriteLine("Часы остановлены");
        }
    }
}
