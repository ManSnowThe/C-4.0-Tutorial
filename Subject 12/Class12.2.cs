// Использовать интерфейс ISeries для реализации
// процесса генерирования простых чисел.
using System;

namespace ca2
{
    public interface ISeries
    {
        int GetNext(); // возвратить следующее по порядку число
        void Reset(); // перезапустить
        void SetStart(int х); // задать начальное значение
    }
    class Primes : ISeries
    {
        int start;
        int val;
        public Primes()
        {
            start = 2;
            val = 2;
        }
        public int GetNext()
        {
            int i, j;
            bool isprime;
            val++;
            for (i = val; i < 1000000; i++)
            {
                isprime = true;
                for (j = 2; j <= i / j; j++)
                {
                    if ((i % j) == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    val = i;
                    break;
                }
            }
            return val;
        }
        public void Reset()
        {
            val = start;
        }
        public void SetStart(int x)
        {
            start = x;
            val = start;
        }
    }
    class SeriesDemo
    {
        static void Main()
        {
            Primes ob = new Primes();
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

        }
    }
}
