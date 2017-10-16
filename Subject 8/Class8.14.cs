//Использовать фабрику класса
using System;

namespace ca2
{
    class MyClass
    {
        int a, b; //Закрытые члены класса
        //Создать фабрику для класса MyClass
        public MyClass Factory(int i, int j)
        {
            MyClass t = new MyClass();
            t.a = i;
            t.b = j;

            return t; //Возвратить объект
        }
        public void Show()
        {
            Console.WriteLine("a и b: " + a + " " + b);
        }
    }
    class MakeObject
    {
        static void Main()
        {
            MyClass ob = new MyClass();
            int s, d;

            for(s=0, d=10; s<10; s++, d--)
            {
                MyClass AnotherOb = ob.Factory(s, d); //Создать объект
                AnotherOb.Show();
            }
            Console.WriteLine();
        }
    }
}
