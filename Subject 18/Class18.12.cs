// Продемонстрировать форму оператора default.
using System;

namespace ca2
{
    class MyClass
    {
        // ...
    }
    // Получить значение, присваиваемое параметру типа Т по умолчанию.
    class Test<T>
    {
        public T obj;

        public Test()
        {
            // Следующий оператор годится только для ссылочных типов.
            // obj = null; // не годится

            // Следующий оператор годится только для типов значений.
            // obj = 0; // не годится

            // А этот оператор годится как для ссылочных типов,
            // так и для типов значений.
            obj = default(T); // Годится!
        }
        // ...
    }
    class DefaultDemo
    {
        static void Main()
        {
            // Сконструировать объект класса Test, используя ссылочный тип.
            Test<MyClass> x = new Test<MyClass>();
            if (x.obj == null)
                Console.WriteLine("Переменная x.obj имеет пустое значение <null>.");

            // Сконструировать объект класса Test, используя ссылочный тип.
            Test<int> y = new Test<int>();
            if (y.obj == 0)
                Console.WriteLine("Переменная у.obj имеет значение 0.");
        }
    }
}
