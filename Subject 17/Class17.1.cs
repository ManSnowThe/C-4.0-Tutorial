// Продемонстрировать применение оператора is.using System;

namespace ca2
{
    class A { }
    class B : A { }
    class UseIs
    {
        static void Main()
        {
            A a = new A();
            B b = new B();
            if (a is A)
                Console.WriteLine("a имеет тип A");
            if (b is A)
                Console.WriteLine("b совместим с A, поскольку он производный от А");
            if (a is B)
                Console.WriteLine("Не выводится, поскольку а не производный от В");
            if (b is B)
                Console.WriteLine("В имеет тип В");
            if (a is object)
                Console.WriteLine("а имеет тип object");
        }
    }
}
