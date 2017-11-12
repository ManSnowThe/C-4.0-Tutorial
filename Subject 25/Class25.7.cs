// Продемонстрировать применение класса Queue.
using System;
using System.Collections;

namespace ca2
{
    class QueueDemo
    {
        static void ShowEnq(Queue q, int a)
        {
            q.Enqueue(a);
            Console.WriteLine("Поместить в очередь: Enqueue(" + a + ")");

            Console.Write("Содержимое очереди: ");
            foreach (int i in q)
                Console.Write(i + " ");

            Console.WriteLine();
        }
        static void ShowDeq(Queue q)
        {
            Console.Write("Извлечь из очереди: Dequeue -> ");
            int a = (int)q.Dequeue();
            Console.WriteLine(a);

            Console.Write("Содержимое очереди: ");
            foreach (int i in q)
                Console.Write(i + " ");

            Console.WriteLine();
        }
        static void Main()
        {
            Queue q = new Queue();

            foreach (int i in q)
                Console.Write(i + " ");

            Console.WriteLine();

            ShowEnq(q, 22);
            ShowEnq(q, 65);
            ShowEnq(q, 91);
            ShowDeq(q);
            ShowDeq(q);
            ShowDeq(q);

            try
            {
                ShowDeq(q);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Очередь пуста.");
            }
        }
    }
}
