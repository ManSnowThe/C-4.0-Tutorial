// Реализовать интерфейс ISeries.
// Продемонстрировать применение класса ByTwos, реализующего интерфейс.
using System;

namespace ca2
{
    public interface ISeries
    {
        int GetNext(); // возвратить следующее по порядку число
        void Reset(); // перезапустить
        void SetStart(int х); // задать начальное значение
    }
    class ByTwos : ISeries
    {
        int start;
        int val;
        int prev;
        public ByTwos()
        {
            start = 0;
            val = 0;
            prev = -2;
        }
        public int GetNext()
        {
            prev = val;
            val += 2;
            return val;
        }
        public void Reset()
        {
            val = start;
            prev = start - 2;
        }
        public void SetStart(int x)
        {
            start = x;
            val = start;
            prev = val - 2;
        }
        public int GetPrevious()
        {
            prev = val - 2;
            val = prev;
            return prev;
        }
    }
    class SeriesDemo
    {
        static void Main()
        {
            ByTwos ob = new ByTwos();
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Следующее число равно " + ob.GetNext());

            Console.WriteLine("\nСбросить");
            ob.Reset();

            for (int i = 0; i < 5; i++)
                Console.WriteLine("Следующее число равно " + ob.GetNext());

            Console.WriteLine("\nНачать с числа 100");
            ob.SetStart(100);

            for (int i = 0; i < 5; i++)
                Console.WriteLine("Следующее число равно " + ob.GetNext());

            Console.WriteLine();

            for (int i=0; i<5; i++)
            Console.WriteLine("Предыдущее число равно " + ob.GetPrevious());

        }
    }
}
