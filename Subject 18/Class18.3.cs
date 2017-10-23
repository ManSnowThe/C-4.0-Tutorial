// Простой обобщенный класс с двумя параметрами типа Т и V.
using System;

namespace ca2
{
    class TwoGen<T, V>
    {
        T ob1;
        V ob2;

        // Обратите внимание на то, что в этом конструкторе
        // указываются параметры типа Т и V.
        public TwoGen(T o1, V o2)
        {
            ob1 = o1;
            ob2 = o2;
        }

        // Показать типы T и V.
        public void ShowTypes()
        {
            Console.WriteLine("К типу T относится: " + typeof(T));
            Console.WriteLine("К типу V относится: " + typeof(V));
        }
        public T GetOb1()
        {
            return ob1;
        }
        public V GetOb2()
        {
            return ob2;
        }
    }
    // Продемонстрировать применение обобщенного класса с двумя параметрами типа.    class SimGen
    {
        static void Main()
        {
            TwoGen<int, string> tgObj = new TwoGen<int, string>(119, "Альфа Бета Гамма");

            // Показать типы.
            tgObj.ShowTypes();

            // Получить и вывести значения.
            int v = tgObj.GetOb1();
            Console.WriteLine("Значение: " + v);
            string str = tgObj.GetOb2();
            Console.WriteLine("Значение: " + str);
        }
    }
}
