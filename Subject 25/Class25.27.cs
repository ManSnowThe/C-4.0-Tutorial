// Реализовать интерфейсы IEnumerable и IEnumerator.
using System;
using System.Collections;

namespace ca2
{
    class MyClass : IEnumerator, IEnumerable
    {
        char[] chrs = { 'A', 'B', 'C', 'D' };
        int idx = -1;

        // Реализовать интерфейс IEnumerable.
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        // В следующих методах реализуется интерфейс IEnumenator

        // Возвратить текущий объект.
        public object Current
        {
            get
            {
                return chrs[idx];
            }
        }
        // Перейти к следующему объекту.
        public bool MoveNext()
        {
            if (idx == chrs.Length - 1)
            {
                Reset(); // установить перечислитель в конец
                return false;
            }
            idx++;
            return true;
        }
        // Установить перечеслитель в начало.
        public void Reset()
        {
            idx = -1;
        }
    }
    class EnumeratorImplDemo
    {
        static void Main()
        {
            MyClass mc = new MyClass();

            // Отобразить содержимое объекта mc.
            foreach (char ch in mc)
                Console.Write(ch + " ");

            Console.WriteLine();

            // Вновь отобразить содержимое объекта mc.
            foreach (char ch in mc)
                Console.Write(ch + " ");

            Console.WriteLine();
        }
    }
}
