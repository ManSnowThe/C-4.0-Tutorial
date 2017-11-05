// Отформатировать объект типа TimeSpan.
using System;

namespace ca2
{
    class TimeSpanDemo
    {
        static void Main()
        {
            DateTime start = DateTime.Now;

            // Вывести числа от 1 до 1000.
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(i + " ");
                if ((i % 10) == 0) Console.WriteLine();
            }

            Console.WriteLine();

            DateTime end = DateTime.Now;

            TimeSpan span = end - start;

            Console.WriteLine("Время выполнения: {0:c}", span);
            Console.WriteLine("Время выполнения: {0:g}", span);
            Console.WriteLine("Время выполнения: {0:G}", span);
            Console.WriteLine("Время выполнения: 0.{0:fff} секунды", span);
        }
    }
}
