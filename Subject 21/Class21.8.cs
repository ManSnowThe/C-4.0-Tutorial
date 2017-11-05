// Скопировать массив.
using System;

namespace ca2
{
    class CopyDemo
    {
        static void Main()
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = { 11, 12, 13, 14, 15 };
            int[] source2 = { -1, -2, -3, -4, -5 };
            
            // Отобразить исходный массив.
            Console.Write("Исходный массив: ");
            foreach (int i in source)
                Console.Write(i + " ");
            Console.WriteLine();

            // Отобразить исходное содержимое целевого массива.
            Console.Write("Исходное содержимое целевого массива: ");
            foreach (int i in target)
                Console.Write(i + " ");
            Console.WriteLine();

            // Скопировать весь массив.
            Array.Copy(source, target, source.Length);

            // Отобразить копию.
            Console.Write("Целевой массив после копирования: ");
            foreach (int i in target)
                Console.Write(i + " ");
            Console.WriteLine();

            // Скопировать в средину целевого массива.
            Array.Copy(source2, 2, target, 3, 2);

            // Отобразить копию.
            Console.Write("Целевой массив после частичного копирования: ");
            foreach (int i in target)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
