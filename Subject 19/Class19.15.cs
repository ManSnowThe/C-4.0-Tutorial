﻿// Использовать анонимный тип для усовершенствования
// программы, демонстрирующей применение оператора join.using System;
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
    // Класс, связывающий наименование товара с состоянием его запасов на складе.
    class InStockStatus
    {
        public int ItemNumber { get; set; }
        public bool InStock { get; set; }
        public InStockStatus(int n, bool b)
        {
            ItemNumber = n;
            InStock = b;
        }
    }
    class AnonTypeDemo
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
                new InStockStatus(6411, true)            };
            // Сформировать запрос, объединяющий объекты классов Item и
            // InStockStatus для составления списка наименований товаров и их
            // наличия на складе. Теперь для этой цели используется анонимный тип.
            var inStockList = from item in items
                              join entry in statusList
                              on item.ItemNumber equals entry.ItemNumber
                              select new { Name = item.Name, InStock = entry.InStock };

            Console.WriteLine("Товар\tНаличие\n");
            // Выполнить запрос и вывести его результаты.
            foreach (var t in inStockList)
                Console.WriteLine("{0}\t{1}", t.Name, t.InStock);
        }
    }
}
