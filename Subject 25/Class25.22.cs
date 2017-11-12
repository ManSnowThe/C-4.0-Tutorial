// Реализовать интерфейс IComparable<T>.
using System;
using System.Collections.Generic;

namespace ca2
{
    // Реализовать обобщенный вариант интерфейса IComparable<T>.
    class Inventory : IComparable<Inventory>
    {
        string name;
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
        // Реализовать интерфейс IComparable<T>.
        public int CompareTo(Inventory obj)
        {
            return name.CompareTo(obj.name);
        }
    }
    class GenericIComparableDemo
    {
        static void Main()
        {
            List<Inventory> inv = new List<Inventory>();

            // Добавить элементы в список.
            inv.Add(new Inventory("Кусачки", 5.95, 3));
            inv.Add(new Inventory("Отвертки", 8.29, 2));
            inv.Add(new Inventory("Молотки", 3.50, 4));
            inv.Add(new Inventory("Дрели", 19.88, 8));

            Console.WriteLine("Перечень товарных запасов до сортировки:");
            foreach (Inventory i in inv)
                Console.WriteLine(" " + i);

            Console.WriteLine();

            // Отсортировать список.
            inv.Sort();
            // inv.Reverse();

            Console.WriteLine("Перечень товарных запасов после сортировки:");
            foreach (Inventory i in inv)
                Console.WriteLine(" " + i);
        }
    }
}
