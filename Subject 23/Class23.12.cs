// Использовать семафор.
using System;
using System.Threading;

namespace ca2
{
    // Этот поток разрешает одновременное выполнение
    // только двух своих экземпляров.
    class MyThread
    {
        public Thread Thrd;

        // Здесь создается семафор, дающий только два
        // разрешения из двух первоначально имеющихся.
        static Semaphore sem = new Semaphore(2, 2);

        public MyThread(string name)
        {
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start();
        }

        // Точка входа в поток.
        void Run()
        {
            Console.WriteLine(Thrd.Name + " ожидает разрешения.");

            sem.WaitOne();

            Console.WriteLine(Thrd.Name + " получает разрешение.");

            for (char ch = 'A'; ch < 'D'; ch++)
            {
                Console.WriteLine(Thrd.Name + " : " + ch + " ");
                Thread.Sleep(500);
            }

            Console.WriteLine(Thrd.Name + " высвобождает разрешение.");

            // Освободить семафор.
            sem.Release();
        }
    }
    class SemaphoreDemo
    {
        static void Main()
        {
            // Сконструировать три потока.
            MyThread mt1 = new MyThread("Поток #1");
            MyThread mt2 = new MyThread("Поток #2");
            MyThread mt3 = new MyThread("Поток #3");

            mt1.Thrd.Join();
            mt2.Thrd.Join();
            mt3.Thrd.Join();
        }
    }
}
