// Продемонстрировать порядок вызова конструкторов.
using System;

namespace ca2
{
    // Создать базовый класс.
    class А
    {
        public А()
        {
            Console.WriteLine("Конструирование класса А.");
        }
    }
    // Создать класс, производный от класса А.
    class В : А
    {
        public В()
        {
            Console.WriteLine("Конструирование класса В.");
        }
    }
    // Создать класс, производный от класса В.
    class С : В
    {
        public С()
        {
            Console.WriteLine("Конструирование класса С.");
        }
    }
    class OrderOfConstruction
    {
        static void Main()
        {
            С с = new С();
        }
    }
}
