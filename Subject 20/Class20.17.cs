// Продемонстрировать применение поля с ключевым словом readonly.
using System;

namespace ca2
{
    class MyClass
    {
        public static readonly int SIZE = 10;
    }
    class DemoReadOnly
    {
        static void Main()
        {
            int[] source = new int[MyClass.SIZE];
            int[] target = new int[MyClass.SIZE];

            // Присвоить ряд значений элементам массива source.
            for (int i = 0; i < MyClass.SIZE; i++)
                source[i] = i;

            foreach (int i in source)
                Console.Write(i + " ");

            Console.WriteLine();

            // Перенести обращенную копию массива source в массив target.
            for (int i = MyClass.SIZE - 1, j = 0; i > 0; i--, j++)
                target[j] = source[i];

            foreach (int i in target)
                Console.Write(i + " ");

            Console.WriteLine();

            // MyClass.SIZE = 100; // Ошибка!!! He подлежит изменению!
        }
    }
}
