// Продемонстрировать применение класса Queue<T>.
using System;
using System.Collections.Generic;

namespace ca2
{
    class GenQueueDemo
    {
        static void Main()
        {
            Queue<double> q = new Queue<double>();

            q.Enqueue(98.6);
            q.Enqueue(212.0);
            q.Enqueue(32.0);
            q.Enqueue(3.1416);

            double sum = 0.0;
            Console.Write("Очередь содержит: ");
            while(q.Count > 0)
            {
                double val = q.Dequeue();
                Console.Write(val + " ");
                sum += val;
            }
            Console.WriteLine("\nИтоговая сумма равна " + sum);
        }
    }
}
