// Продемонстрировать применение оператора as.using System;

namespace ca2
{
    class A { }
    class B : A { }
    class CheckCast
    {
        static void Main()
        {
            A a = new A();
            B b = new B();
            b = a as B;  // выполнить приведение типов, если это возможно
            if(b==null)
                Console.WriteLine("Приведение типов b = (В) НЕ допустимо.");
            else
                Console.WriteLine("Приведение типов b = (В) допустимо.");
        }
    }
}
