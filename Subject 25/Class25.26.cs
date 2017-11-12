// Продемонстрировать применение перечислителя типа IDictionaryEnumerator.
using System;
using System.Collections;

namespace ca2
{
    class IDicEnumDemo
    {
        static void Main()
        {
            // Создать хеш-таблицу.
            Hashtable ht = new Hashtable();

            // Добавить элементы в таблицу.
            ht.Add("Кен", "555-7756");
            ht.Add("Мэри", "555-9876");
            ht.Add("Том", "555-3456");
            ht.Add("Тодд", "555-3452");

            // Продемонстрировать применение перечислителя.
            IDictionaryEnumerator etr = ht.GetEnumerator();

            Console.WriteLine("Отобразить информацию с помощью свойства Entry.");
            while (etr.MoveNext())
                Console.WriteLine(etr.Entry.Key + ": " + etr.Entry.Value);

            Console.WriteLine();

            Console.WriteLine("Отобразить информацию с помощью свойств Key и Value.");
            etr.Reset();
            while (etr.MoveNext())
                Console.WriteLine(etr.Key + ": " + etr.Value);
        }
    }
}
