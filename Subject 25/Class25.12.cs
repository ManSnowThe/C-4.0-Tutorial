// Продемонстрировать применение класса обобщенной
// коллекции SortedDictionary<TKey, TValue>.
using System;
using System.Collections.Generic;

namespace ca2
{
    class GenSortedDictionaryDemo
    {
        static void Main()
        {
            // Создать словарь для хранения имен и фамилий
            // работников и их зарплаты.
            SortedDictionary<string, double> dict = new SortedDictionary<string, double>();

            // Добавить элементы в коллекцию.
            dict.Add("Батлер, Джон", 73000);
            dict.Add("Шварц, Capa", 59000);
            dict.Add("Пайк, Томас", 45000);
            dict.Add("Фрэнк, Эд", 99000);

            // Получить коллекцию ключей, т.е. фамилий и имен.
            ICollection<string> c = dict.Keys;

            // Использовать ключи для получения значений, т.е. зарплаты.
            foreach (string str in c)
                Console.WriteLine("{0}, зарплата: {1:C}", str, dict[str]);
        }
    }
}
