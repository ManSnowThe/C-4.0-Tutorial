// Применить инициализаторы объектов в свойствах.
using System;

namespace ca2
{
    class MyClass
    {
        // Теперь это свойства.
        public int Count { get; set; }
        public string Str { get; set; }
    }
    class ObjInitDemo
    {
        static void Main()
        {
            // Сконструировать объект типа MyClass с помощью объектов.
            MyClass obj = new MyClass { Count = 100, Str = "Тестирование" };

            Console.WriteLine(obj.Count + " " + obj.Str);
        }
    }
}
