// Продемонстрировать применение перечислителя.
using System;
using System.Collections;

namespace ca2
{
    class EnumeratorDemo
    {
        static void Main()
        {
            ArrayList list = new ArrayList(1);

            for (int i = 0; i < 10; i++)
                list.Add(i);

            // Использовать перечислитель для доступа к списку.
            IEnumerator etr = list.GetEnumerator();
            while (etr.MoveNext())
                Console.Write(etr.Current + " ");

            Console.WriteLine();

            // Повторить перечисление списка.
            etr.Reset();
            while (etr.MoveNext())
                Console.Write(etr.Current + " ");

            Console.WriteLine();
        }
    }
}
