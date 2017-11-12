// Продемонстрировать применение класса Hashtable.
using System;
using System.Collections;

namespace ca2
{
    class HashtableDemo
    {
        static void Main()
        {
            // Создать хеш-таблицу.
            Hashtable ht = new Hashtable();

            // Добавить элементы в таблицу.
            ht.Add("здание", "жилое помещение");
            ht.Add("автомашина", "транспортное средство");
            ht.Add("книга", "набор печатных слов");
            ht.Add("яблоко", "съедобный плод");

            // Добавить элементы с помощью индексатора.
            ht["трактор"] = "сельскохозяйственная машина";

            // Получить коллекцию ключей.
            ICollection c = ht.Keys;

            // Использовать ключи для получения значений.
            foreach (string str in c)
                Console.WriteLine(str + ": " + ht[str]);
        }
    }
}
