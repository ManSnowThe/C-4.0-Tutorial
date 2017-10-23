// Простой пример, демонстрирующий механизм наложения
// ограничения на базовый класс.using System;

namespace ca2
{
    class A
    {
        public void Hello()
        {
            Console.WriteLine("Hello");
        }
    }
    // Класс B наследует класс A
    class B : A { }
    // Класс C не наследует класс A
    class C { }
    
    // В силу ограничения на базовый класс во всех аргументах типа,
    // передаваемых классу Test, должен присутствовать базовый класс А.
    class Test<T>where T : A
    {
        T obj;

        public Test(T o)
        {
            obj = o;
        }
        public void SayHello()
        {
            // Метод Hello() вызывается, поскольку он объявлен в базовом классе А.
            obj.Hello();
        }
    }
    class BaseClassConstraintDemo
    {
        static void Main()
        {
            A a = new ca2.A();
            B b = new ca2.B();
            C c = new ca2.C();

            // Следующий код вполне допустим, поскольку класс А указан как базовый.
            Test<A> t1 = new Test<A>(a);
            t1.SayHello();

            // Следующий код вполне допустим, поскольку класс В наследует от класса А.
            Test<B> t2 = new Test<B>(b);
            t2.SayHello();

            // Следующий код недопустим, поскольку класс С не наследует от класса А.
            // Test<C> t3 = new Test<C>(c); // Ошибка!
            // t3.SayHello(); // Ошибка!
        }
    }
}
