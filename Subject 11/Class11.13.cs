// Продемонстрировать виртуальный метод.
using System;

namespace ca2
{
    class Base
    {
        // Создать виртуальный метод в базовом классе.        public virtual void Who()
        {
            Console.WriteLine("Метод Who() в классе Base");
        }
    }
    class Derived1 : Base
    {
        // Переопределить метод Who() в производном классе.
        public override void Who()
        {
            Console.WriteLine("Метод Who() в классе Derived1");
        }
    }
    class Derived2 :Base
    {
        // Вновь переопределить метод Who() в еще одном производном классе
        public override void Who()
        {
            Console.WriteLine("Метод Who() в классе Derived2");
        }
    }
    class OverrideDemo
    {
        static void Main()
        {
            Base baseOb = new ca2.Base();
            Derived1 dOb1 = new Derived1();
            Derived2 dOb2 = new Derived2();

            Base baseRef; // ссылка на базовый класс

            baseRef = baseOb;
            baseRef.Who();

            baseRef = dOb1;
            baseRef.Who();

            baseRef = dOb2;
            baseRef.Who();
        }
    }
}
