// Простая иерархия обобщенных классов.
// +
// Пример добавления собственных параметров типа в производный класс.
using System;

namespace ca2
{
    // Обобщенный базовый класс.
    class Gen<T>
    {
        T ob;
        public Gen(T o)
        {
            ob = o;
        }
        // Возвратить значение переменной ob.
        public T GetOb()
        {
            return ob;
        }
    }
    // Класс, производный от класса Gen.
    class Gen2<T,V> : Gen<T>
    {
        V ob2;
        public Gen2(T o, V o2) : base(o)
        {
            ob2 = o2;
        }
        public V GetObj2()
        {
            return ob2;
        }
    }
    // Создать объект класса Gen2.
    class GenHierDemo2
    {
        static void Main()
        {
            // Создать объект класса Gen2 с параметрами
            // типа string и int.
            Gen2<string, int> x = new Gen2<string, int>("Значение равно: ", 99);
            Console.Write(x.GetOb());
            Console.WriteLine(x.GetObj2());
        }
    }
}
