// Продемонстрировать интерфейсные ссылки.using System;

namespace ca2
{
    // Определить интерфейс.
    public interface ISeries
    {
        int GetNext();// возвратить следующее по порядку число
        void Reset(); // перезапустить
        void SetStart(int х); // задать начальное значение
    }
    // Использовать интерфейс ISeries для реализации процесса
    // генерирования последовательного ряда чисел, в котором каждое
    // последующее число на два больше предыдущего.
    class ByTwos : ISeries
    {
        int start;
        int val;

        public ByTwos()
        {
            start = 0;
            val = 0;
        }
        public int GetNext()
        {
            val += 2;
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
    // Использовать интерфейс ISeries для реализации
    // процесса генерирования простых чисел.
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
                for(i=val; i<1000000; i++)
            {
                isprime = true;
                for(j=2;j<=i/j; j++)
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
    class SeriesDemo2
    {
        static void Main()
        {
            ByTwos twoOb = new ByTwos();
            Primes primeOb = new Primes();
            ISeries ob;

            for (int i=0; i<5; i++)
            {
                ob = twoOb;
                Console.WriteLine("Следующее четное число равно " + ob.GetNext());

                ob = primeOb;
                Console.WriteLine("Следующее простое число " + "равно " + ob.GetNext());
            }
        }
    }
}
