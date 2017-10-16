// Вложенные пространства имен.
using System;

namespace NS1
{
    class ClassA
    {
        public ClassA()
        {
            Console.WriteLine("Конструирование класса ClassA.");
        }
    }
    namespace NS2
    {
        class ClassB
        {
            public ClassB()
            {
                Console.WriteLine("Конструирование класса ClassB");
            }
        }
    }
}
class NestedNSDemo
{
    static void Main()
    {
        NS1.ClassA a = new NS1.ClassA();
        // NS2.ClassB b = new NS2.ClassB(); // Неверно!!! Пространство имен NS2 невидимо
        NS1.NS2.ClassB b = new NS1.NS2.ClassB(); // Верно!
    }
}
