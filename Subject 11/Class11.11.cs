// По ссылке на объект базового класса можно обращаться
// к объекту производного класса.
using System;
namespace ca2
{
    class X
    {
        public int a;
        public X(int i)
        {
            a = i;
        }
    }
    class Y : X
    {
        public int b;
        public Y(int i, int j) : base(j)
        {
            b = i;
        }
    }
    class BaseRef
    {
        static void Main()
        {
            X x = new X(10);
            X x2;
            Y у = new Y(5, 6);

            x2 = x; // верно, поскольку оба объекта относятся к одному и тому же типу
            Console.WriteLine("х2.а: " + x2.a);
            x2 = у; // тоже верно, поскольку класс Y является производным от класса X
            Console.WriteLine("х2.а: " + x2.a);
            
            // ссылкам на объекты класса X известно только о членах класса X
            x2.a = 19; // верно
            // х2.b = 27; // неверно, поскольку член b отсутствует у класса X
        }
    }
}