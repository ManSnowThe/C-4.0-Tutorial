// Продемонстрировать перегрузку конструктора.
using System;

namespace ca2
{
    class MyClass
    {
        public int x;
        public MyClass()
        {
            Console.WriteLine("В конструкторе MyClass().");
            x = 0;
        }
        public MyClass(int i)
        {
            Console.WriteLine("В конструкторе MyClass(int).");
            x = i;
        }
            public MyClass(double d)
        {
            Console.WriteLine("В конструкторе MyClass(double).");
            x = (int)d;
        }
        public MyClass(int i, int j)
        {
            Console.WriteLine("В конструкторе MyClass(int, int).");
            x = i * j;
        }
    }
    class OverloadConsDemo
    {
        static void Main()
        {
            MyClass t1 = new ca2.MyClass();
            MyClass t2 = new MyClass(88);
            MyClass t3 = new MyClass(17.23);
            MyClass t4 = new MyClass(2, 4);

            Console.WriteLine("t1.x: " + t1.x);
            Console.WriteLine("t2.х: " + t2.x);
            Console.WriteLine("t3.x: " + t3.x);
            Console.WriteLine("t4.x: " + t4.x);
        }
    }
}
