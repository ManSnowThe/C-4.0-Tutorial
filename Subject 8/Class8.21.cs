// Простой пример, демонстрирующий применение инициализаторов объектов.
using System;

namespace ca2
{
    class MyClass
    {
        public int Count;
        public string Str;
    }
    class ObjInitDemo
    {
        static void Main()
        {
            // Сконструировать объект типа MyClass, используя инициализаторов объектов.
            MyClass obj = new MyClass { Count = 100, Str = "Тестирование" };

            Console.WriteLine(obj.Count + " " + obj.Str);
        }
    }
}
