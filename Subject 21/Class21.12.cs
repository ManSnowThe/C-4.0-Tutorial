// Продемонстрировать применение интерфейса ICloneable.
using System;

namespace ca2
{
    class X
    {
        public int a;

        public X(int x)
        {
            a = x;
        }
    }
    class Test : ICloneable
    {
        public X o;
        public int b;

        public Test(int x, int y)
        {
            o = new X(x);
            b = y;
        }
        public void Show(string name)
        {
            Console.Write("Значение объекта " + name + ": ");
            Console.WriteLine("o.a: {0}, b: {1}", o.a, b);
        }

        // Создать полную копию вызывающего объекта.
        public object Clone()
        {
            Test temp = new Test(o.a, b);
            return temp;
        }
        /* Сделать неполную копию вызывающего объекта.
        public object Clone()
        {
            Test temp = (Test)MemberwiseClone();
            return temp;
        }*/
    }
    class CloneDemo
    {
        static void Main()
        {
            Test ob1 = new Test(10, 20);

            ob1.Show("ob1");

            Console.WriteLine("Сделать объект ob2 копией объекта оb1.");
            Test ob2 = (Test)ob1.Clone();

            ob2.Show("ob2");

            Console.WriteLine("Изменить значение оb1.о.а на 99, а значение оb1.b - на 88.");

            ob1.o.a = 99;
            ob1.b = 88;

            ob1.Show("ob1");
            ob2.Show("ob2");
        }
    }
}
