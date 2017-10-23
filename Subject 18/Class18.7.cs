// Продемонстрировать наложение ограничения new() на конструктор.
using System;

namespace ca2
{
    class MyClass
    {
        public MyClass()
        {
            //...
        }
        //...
    }
    class Test<T> where T : new()
    {
        T obj;
        public Test()
        {
            // Этот код работоспособен благодаря наложению ограничения new().
            obj = new T(); // создать объект типа T
        }
        //...
    }
    class ConsConstraintDemo
    {
        static void Main()
        {
            Test<MyClass> x = new Test<MyClass>();
        }
    }
}
