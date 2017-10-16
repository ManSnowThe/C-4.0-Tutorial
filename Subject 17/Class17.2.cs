// Использовать оператор is для предотвращения неправильного приведения типов.
using System;

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
            // Проверить, можно ли привести а к типу В.
            if (a is B) // Если да, то выполнить приведение типов
                b = (B)a;
            else // если нет, то пропустить приведение типов
                b = null;

            if(b==null)
                Console.WriteLine("Приведение типов b = (В) HE допустимо.");
            else
                Console.WriteLine("Приведение типов b = (В) допустимо.");
        }
    }
}
