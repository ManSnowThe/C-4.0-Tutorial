// Продемонстрировать применение класса обобщенной
// коллекции SortedList<TKey, TValue>.
using System;
using System.Collections.Generic;

namespace ca2
{
    class GenSortedDictionaryDemo
    {
        static void Main()
        {
            // Создать коллекцию в виде отсортированного списка
            // для хранения имен и фамилий работников и их зарплаты.
            SortedList<string, double> sl = new SortedList<string, double>();

            // Добавить элементы в коллекцию.
            sl.Add("Батлер, Джон", 73000);
            sl.Add("Шварц, Capa", 59000);
            sl.Add("Пайк, Томас", 45000);
            sl.Add("Фрэнк, Эд", 99000);

            // Получить коллекцию ключей, т.е. фамилий и имен.
            ICollection<string> c = sl.Keys;

            // Использовать ключи для получения значений, т.е. зарплаты.
            foreach (string str in c)
                Console.WriteLine("{0}, зарплата: {1:C}", str, sl[str]);

            Console.WriteLine();
        }
    }
}
