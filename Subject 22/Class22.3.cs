// Продемонстрировать применение объектной формы метода Concat().
using System;

namespace ca2
{
    class MyClass
    {
        public static int Count = 0;

        public MyClass()
        {
            Count++;
        }
        public override string ToString()
        {
            return "Объект типа MyClass";
        }
    }
    class ConcatDemo
    {
        static void Main()
        {
            string result = String.Concat("значение равно " + 19);
            Console.WriteLine("Результат: " + result);

            result = String.Concat("привет ", 88, " ", 20.0, " ", false, " ", 23.45M);
            Console.WriteLine("Результат: " + result);

            MyClass me = new MyClass();

            result = String.Concat(me, " текущий счет равен ", MyClass.Count);
            Console.WriteLine("Результат: " + result);
        }
    }
}
