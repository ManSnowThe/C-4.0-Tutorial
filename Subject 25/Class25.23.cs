// Использовать необобщенный вариант интерфейса IComparer.
using System;
using System.Collections;

namespace ca2
{
    // Создать объект типа IComparer для объектов класса Inventory.
    class CompInv : IComparer
    {
        // Реализовать интерфейс IComparer.
        public int Compare(object x, object y)
        {
            Inventory a, b;
            a = (Inventory)x;
            b = (Inventory)y;
            return string.Compare(a.name, b.name, StringComparison.Ordinal);
        }
    }
    // Реализовать необобщенный вариант интерфейса IComparable.
    class Inventory
    {
        public string name;
        double cost;
        int onhand;

        public Inventory(string n, double c, int h)
        {
            name = n;
            cost = c;
            onhand = h;
        }
        public override string ToString()
        {
            return String.Format("{0,-10}Стоимость: {1,6:C} Наличие: {2}", name, cost, onhand);
        }
    }
    class IComparableDemo
    {
        static void Main()
        {
            CompInv comp = new CompInv();
            ArrayList inv = new ArrayList();

            // Добавить элементы в список.
            inv.Add(new Inventory("Кусачки", 5.95, 3));
            inv.Add(new Inventory("Отвертки", 8.29, 2));
            inv.Add(new Inventory("Молотки", 3.50, 4));
            inv.Add(new Inventory("Дрели", 19.88, 8));

            Console.WriteLine("Перечень товарных запасов до сортировки:");
            foreach (Inventory i in inv)
                Console.WriteLine(" " + i);

            Console.WriteLine();

            // Отсортировать список, используя интерфейс IComparer.
            inv.Sort(comp);
            // inv.Reverse();

            Console.WriteLine("Перечень товарных запасов после сортировки:");
            foreach (Inventory i in inv)
                Console.WriteLine(" " + i);
        }
    }
}
