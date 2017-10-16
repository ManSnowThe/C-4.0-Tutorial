// Добавить индексатор в интерфейс.
using System;

namespace ca2
{
    public interface ISeries
    {
        // Интерфейсное свойство
        int Next
        {
            get; // возвратить следующее по порядку число
            set; // установить следующее число
        }        // Интерфейсный индексатор.        int this[int index]
        {
            get; // возвратить указанное в ряду число
        }
    }
    // Реализовать интерфейс ISeries.
    class ByTwos : ISeries
    {
        int val;
        public ByTwos()
        {
            val = 0;
        }
        // Получить или установить значение с помощью свойства.
        public int Next
        {
            get
            {
                val += 2;
                return val;
            }
            set
            {
                val = value;
            }
        }
        // Получить значение по индексу
        public int this[int index]
        {
            get
            {
                val = 0;
                for (int i = 0; i < index; i++)
                    val += 2;
                return val;
            }
        }
    }
    // Продемонстрировать применение интерфейсного индексатора.
    class SeriesDemo4
    {
        static void Main()
        {
            ByTwos ob = new ByTwos();

            // Получить доступ к последовательному ряду чисел с помощью свойства.
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Следующее число равно " + ob.Next);

            Console.WriteLine("\nНачать с числа 21");
            ob.Next = 21;
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Следующее число равно " + ob.Next);

            Console.WriteLine("\nСбросить в 0");
            ob.Next = 0;

            // Получить доступ к последовательному ряду чисел с помощью индексатора
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Следующее число равно " + ob[i]);
        }
    }
}
