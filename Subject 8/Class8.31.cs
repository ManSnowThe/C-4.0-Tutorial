// Использовать статическую фабрику класса.
using System;

namespace ca2
{
    class MyClass
    {
        int a, b;
        
        // Создать фабрику для класса MyClass.
        static public MyClass Factory(int i, int j)
        {
            MyClass t = new MyClass();

            t.a = i;
            t.b = j;

            return t; // Возвратить объект
        }
        public void Show()
        {
            Console.WriteLine("а и b: " + a + " " + b);
        }
    }
    class MakeObjects
    {
        static void Main()
        {
            int i, j;
            
            // Сформировать объекты, используя фабрику.
            for(i=0, j=10; i<10; i++, j--)
            {
                MyClass ob = MyClass.Factory(i, j); // Создать объект
                ob.Show();
            }
            Console.WriteLine();
        }
    }
}
