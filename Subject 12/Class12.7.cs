// Реализовать член интерфейса явно.
using System;

namespace ca2
{
    interface IEven
    {
        bool IsOdd(int x);
        bool IsEven(int x);
    }
    class MyClass : IEven
    {
        // Явная реализация. Обратите внимание на то, что
        // этот член является закрытым по умолчанию.
        bool IEven.IsOdd(int x)
        {
            if ((x % 2) != 0) return true;
            else return false;
        }
        // Обычная реализация.
        public bool IsEven(int x)
        {
            IEven o = this; // Интерфейсная ссылка на вызывающий объект.
            return !o.IsOdd(x);
        }
    }
    class Demo
    {
        static void Main()
        {
            MyClass ob = new MyClass();
            bool result;

            result = ob.IsEven(4);
            if (result) Console.WriteLine("4 - четное число.");
            
            // result = ob.IsOdd(4); // Ошибка, член IsOdd интерфейса IEven недоступен
            
            // Но следующий код написан верно, поскольку в нем сначала создается
            // интерфейсная ссылка типа IEven на объект класса MyClass, а затем по
            // этой ссылке вызывается метод IsOdd().
            IEven iRef = (IEven)ob;
            result = iRef.IsOdd(3);
            if (result) Console.WriteLine("3 — нечетное число.");
        }
    }
}