using System;
// Объявить пространство имен для счетчиков.
namespace Counter
{
    // Простой вычетающий счетчик.
    class CountDown
    {
        int val;

        public CountDown(int n)
        {
            val = n;
        }
        public void Reset(int n)
        {
            val = n;
        }
        public int Count()
        {
            if (val > 0) return val--;
            else return 0;
        }
    }
} // Это конец пространства имен Counter.

// Продемонстрировать применение пространства имен Counter.
class NSDemo
{
    static void Main()
    {
        // Обратите внимание на то, как класс CountDown
        // определяется с помощью пространства имен Counter.
        Counter.CountDown cd1 = new Counter.CountDown(10);
        int i;

        do
        {
            i = cd1.Count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();

        // Еще раз обратите внимание на то, как класс CountDown
        // определяется с помощью пространства имен Counter.
        Counter.CountDown cd2 = new Counter.CountDown(20);

        do
        {
            i = cd2.Count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();

        cd2.Reset(4);
        do
        {
            i = cd2.Count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();
    }
}