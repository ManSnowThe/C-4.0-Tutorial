// Использовать специальное исключение для обработки
// ошибок при обращении к массиву класса RangeArray.
using System;

namespace ca2
{
    // Создать исключение для класса RangeArray.
    class RangeArrayException : Exception
    {
        /* Реализовать все конструкторы класса Exception. Такие конструкторы просто
         * реализуют конструктор базового класса. А поскольку класс исключения
         * RangeArrayException ничего не добавляет к классу Exception, то никаких
         * дополнительных действий не требуется. */
        public RangeArrayException() : base() { }
        public RangeArrayException(string str) : base(str) { }
        public RangeArrayException(string str, Exception inner) : base(str, inner) { }
        protected RangeArrayException(System.Runtime.Serialization.SerializationInfo si,
            System.Runtime.Serialization.StreamingContext sc) : base(si, sc) { }

        // Переопределить метод ToString() для класса исключения RangeArrayException.
        public override string ToString()
        {
            return Message;
        }
    }
    // Улучшенный вариант класса RangeArray.
    class RangeArray
    {

        // Закрытые данные
        int[] a; // ссылка на базовый массив
        int lowerbound; // наименьший индекс
        int upperbound; // наибольший индекс

        // Автоматически реализуемое и доступное только для чтения свойство Length.
        public int Length
        {
            get;
            private set;
        }
        // Построить массив по заданному размеру
        public RangeArray(int low, int high)
        {
            high++;
            if (high <= low)
            {
                throw new RangeArrayException("Нижний индекс не меньше верхнего.");
            }
            a = new int[high - low];
            Length = high - low;

            lowerbound = low;
            upperbound = --high;
        }
        // Это индексатор для класса RangeArray.
        public int this[int index]
        {
            // Это аксессор get
            get
            {
                if (ok(index))
                {
                    return a[index - lowerbound];
                }
                else
                {
                    throw new RangeArrayException("Ошибка нарушения границ");
                }
            }
            // Это аксессор set
            set
            {
                if (ok(index))
                {
                    a[index - lowerbound] = value;
                }
                else throw new RangeArrayException("Ошибка нарушения границ");
            }
        }
        // Возвратить логическое значение true, если
        // индекс находится в установленных границах
        private bool ok(int index)
        {
            if (index >= lowerbound & index <= upperbound) return true;
            return false;
        }
    }
    // Продемонстрировать применение массива с произвольно
    // задаваемыми пределами индексирования.
    class RangeArrayDemo
    {
        static void Main()
        {
            try
            {
                RangeArray ra = new RangeArray(-5, 5);
                RangeArray ra2 = new RangeArray(1, 10);

                // Использовать объект ra в качестве массива.
                Console.WriteLine("Длина массива ra: " + ra.Length);
                for (int i = -5; i <= 5; i++)
                    ra[i] = i;

                Console.Write("Содержимое массива ra: ");
                for (int i = -5; i <= 5; i++)
                    Console.Write(ra[i] + " ");

                Console.WriteLine("\n");

                // Использовать объект ra2 в качестве массива.
                Console.WriteLine("Длина массива ra2: " + ra2.Length);
                for (int i = 1; i <= 10; i++)
                    ra2[i] = i;

                Console.Write("Длина массива ra2: ");
                for (int i = 1; i <= 10; i++)
                    Console.Write(ra2[i] + " ");

                Console.WriteLine("\n");
            }
            catch (RangeArrayException exc)
            {
                Console.WriteLine(exc);
            }
            // А теперь продемонстрировать обработку некоторых ошибок.
            Console.WriteLine("Сгенерировать ошибки нарушения границ.");

            // Использовать неверно заданный конструктор.
            try
            {
                RangeArray ra3 = new RangeArray(100, -10); // Ошибка!
            }
            catch (RangeArrayException exc)
            {
                Console.WriteLine(exc);
            }
            // Использовать неверно заданный индекс.
            try
            {
                RangeArray ra3 = new RangeArray(-2, 2);
                for (int i = -2; i <= 2; i++)
                    ra3[i] = i;
                Console.Write("Содержимое массива ra3: ");
                for (int i = -2; i <= 10; i++) // сгенерировать ошибку нарушения границ
                    Console.Write(ra3[i] + " ");
            }
            catch (RangeArrayException exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}