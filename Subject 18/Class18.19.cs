// Пример необобщенного класса в качестве базового для
// обобщенного производного класса.
using System;

namespace ca2
{
    // Необобщенный базовый класс
    class NonGen
    {
        int num;

        public NonGen(int i)
        {
            num = i;
        }
        public int GetNum()
        {
            return num;
        }
    }
    // Обобщенный производный класс
    class Gen<T> : NonGen
    {
        T ob;
        public Gen(T o, int i) : base(i)
        {
            ob = o;
        }
        // Возвратить значение переменной ob.        public T GetOb()
        {
            return ob;
        }
    }
    // Создать объект класса Gen.    class HierDemo3
    {
        static void Main()
        {
            // Создать объект класса Gen с параметром типа string.
            Gen<string> w = new Gen<string>("Привет", 47);

            Console.Write(w.GetOb() + " ");
            Console.WriteLine(w.GetNum());
        }
    }
}
