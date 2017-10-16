// Воспользоваться явной реализацией для устранения неоднозначности.using System;

namespace ca2
{
    interface IMyF_A
    {
        int Meth(int x);
    }
    interface IMyF_B
    {
        int Meth(int x);
    }
    // Оба интерфейса реализуются в классе MyClass.
    class MyClass : IMyF_A, IMyF_B
    {
        // Реализовать оба метода Meth() явно.
        int IMyF_A.Meth(int x)
        {
            return x + x;
        }
        int IMyF_B.Meth(int x)
        {
            return x * x;
        }

        // Вызывать метод Meth() по интерфейсной ссылке.        public int MethA(int x)
        {
            IMyF_A a_ob;
            a_ob = this;
            return a_ob.Meth(x); // вызов интерфейсного метода IMyIF_A
        }

        public int MethB(int x)
        {
            IMyF_B b_ob;
            b_ob = this;
            return b_ob.Meth(x); // вызов интерфейсного метода IMyIF_B
        }
    }
    class FQIFNames
    {
        static void Main()
        {
            MyClass ob = new MyClass();

            Console.Write("Вызов метода IMyIF_A.Meth(): ");
            Console.WriteLine(ob.MethA(3));

            Console.Write("Вызов метода IMyIF_B.Meth(): ");
            Console.WriteLine(ob.MethB(3));
        }
    }
}