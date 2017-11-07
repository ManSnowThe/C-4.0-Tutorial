// Использовать блокируемые операции.
using System;
using System.Threading;

namespace ca2
{
    // Общий ресурс
    class SharedRes
    {
        public static int Count = 0;
    }
    // В этом потоке переменная SharedRes.Count инкрементируется.
    class IncThread
    {
        public Thread Thrd;

        public IncThread(string name)
        {
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start();
        }

        // Точка входа в поток.
        void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                Interlocked.Increment(ref SharedRes.Count);
                Console.WriteLine(Thrd.Name + " Count = " + SharedRes.Count);
            }
        }
    }
    // В этом потоке переменная SharedRes.Count декрементируется.
    class DecThread
    {
        public Thread Thrd;

        public DecThread(string name)
        {
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start();
        }
        // Точка входа в поток.
        void Run()
        {
            for(int i = 0; i < 5; i++)
            {
                Interlocked.Decrement(ref SharedRes.Count);
                Console.WriteLine(Thrd.Name + " Count = " + SharedRes.Count);
            }
        }
    }
    class InterlockedDemo
    {
        static void Main()
        {
            // Сконструировать два потока.
            IncThread mt1 = new IncThread("Инкрементирующий поток.");
            DecThread mt2 = new DecThread("Декрементирующий поток.");

            mt1.Thrd.Join();
            mt2.Thrd.Join();
        }
    }
}
