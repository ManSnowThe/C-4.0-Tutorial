// Простой пример коллекции товарных запасов.
// +
// Пример сохранения объектов класса Inventory в
// обобщенной коллекции класса List<T>.
using System;
using System.Collections;
using System.Collections.Generic;

namespace ca2
{
    class Inventory
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
    }
    class InventoryList
    {
        static void Main()
        {
            ArrayList inv = new ArrayList(); 
            // List<Inventory> inv = new List<Inventory>();

            // Добавить элементы в список.
            inv.Add(new Inventory("Кусачки", 5.95, 3));
            inv.Add(new Inventory("Отвертки", 8.29, 2));
            inv.Add(new Inventory("Молотки", 3.50, 4));
            inv.Add(new Inventory("Дрели", 19.88, 8));

            Console.WriteLine("Перечень товарных запасов:");
            foreach (Inventory i in inv)
                Console.WriteLine(" " + i);
        }
    }
}
