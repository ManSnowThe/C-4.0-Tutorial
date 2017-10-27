// Продемонстрировать применение оператора join.using System;
using System.Linq;

namespace ca2
{
    // Класс, связывающий наименование товара с его порядковым номером.
    class Item
    {
        public string Name { get; set; }
        public int ItemNumber { get; set; }
        public Item(string n, int inum)
        {
            Name = n;
            ItemNumber = inum;
        }
    }
    // Класс, связывающий наименование товара с состоянием его запасов на складе.    class InStockStatus
    {
        public int ItemNumber { get; set; }
        public bool InStock { get; set; }

        public InStockStatus(int n, bool b)
        {
            ItemNumber = n;
            InStock = b;
        }
    }
    // Класс, инкапсулирующий наименование товара и
    // состояние его запасов на складе.
    class Temp
    {
        public string Name { get; set; }
        public bool InStock { get; set; }
        public Temp(string n, bool b)
        {
            Name = n;
            InStock = b;
        }
    }
    class JoinDemo
    {
        static void Main()
        {
            Item[] items =
            {
                new Item("Кусачки", 1424),
                new Item("Тиски", 7892),
                new Item("Молоток", 8534),
                new Item("Пила", 6411)
            };
            InStockStatus[] statusList =
            {
                new InStockStatus(1424, true),
                new InStockStatus(7892, false),
                new InStockStatus(8534, true),
                new InStockStatus(6411, true)
            };
            // Сформировать запрос, объединяющий объекты классов Item
            // и InStockStatus для составления списка наименований товаров
            // и их наличия на складе. Обратите внимание на формирование
            // последовательности объектов класса Temp.
            var inStockList = from item in items
                              join entry in statusList
                              on item.ItemNumber equals entry.ItemNumber
                              select new Temp(item.Name, entry.InStock);

            /* 
            //Использовать метод запроса Join() для составления списка
            // наименований товаров и состояния их запасов на складе.
            var inStockList = items.Join(statusList,
            k1 => k1.ItemNumber,
            k2 => k2.ItemNumber,
            (k1, k2) => new Temp(k1.Name, k2.InStock));
            */

            Console.WriteLine("Товар\tНаличие\n");

            // Выполнить запрос и вывести его результаты.
            foreach (Temp t in inStockList)
                Console.WriteLine("{0}\t{1}", t.Name, t.InStock);
        }
    }
}
