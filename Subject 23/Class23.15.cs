// Прервать поток с помощью метода Abort().
using System;
using System.Threading;

namespace ca2
{
    class MyThread
    {
        public Thread Thrd;

        public MyThread(string name)
        {
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start();
        }
        // Это точка входа в поток.
        void Run()
        {
            Console.WriteLine(Thrd.Name + " начат.");

            for(int i = 1; i <= 1000; i++)
            {
                Console.Write(i + " ");
                if ((i % 10) == 0)
                {
                    Console.WriteLine();
                    Thread.Sleep(250);
                }
            }
            Console.WriteLine(Thrd.Name + " завершен.");
        }
    }
    class StopDemo
    {
        static void Main()
        {
            MyThread mt1 = new MyThread("Мой Поток");

            Thread.Sleep(1000); // разрешить порожденному потоку начать свое выполнение

            Console.WriteLine("Прерывание потока.");
            mt1.Thrd.Abort();

            mt1.Thrd.Join(); // ожидать прерывание потока

            Console.WriteLine("Основной поток прерван.");
        }
    }
}
