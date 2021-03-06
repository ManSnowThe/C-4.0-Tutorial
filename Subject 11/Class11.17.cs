﻿// Продемонстрировать применение метода ToString()
using System;

namespace ca2
{
    class MyClass
    {
        static int count = 0;
        int id;

        public MyClass()
        {
            id = count;
            count++;
        }
        public override string ToString()
        {
            return "Объект #" + id + " типа MyClass";
        }
    }
    class Test
    {
        static void Main()
        {
            MyClass ob1 = new MyClass();
            MyClass ob2 = new MyClass();
            MyClass ob3 = new MyClass();

            Console.WriteLine(ob1);
            Console.WriteLine(ob2);
            Console.WriteLine(ob3);
        }
    }
}
