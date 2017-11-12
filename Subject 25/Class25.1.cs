// Продемонстрировать применение класса ArrayList.
using System;
using System.Collections;

namespace ca2
{
    class ArrayListDemo
    {
        static void Main()
        {
            // Создать коллекцию в виде динамического массива.
            ArrayList al = new ArrayList();

            Console.WriteLine("Исходное количество элементов: " + al.Count);

            Console.WriteLine();

            Console.WriteLine("Добавить 6 элементов");
            // Добавить элементы в динамический массив.
            al.Add('C');
            al.Add('A');
            al.Add('E');
            al.Add('В');
            al.Add('D');
            al.Add('F');

            Console.WriteLine("Количество элементов: " + al.Count);

            // Отобразить содержимое динамического массива,
            // используя индексирование массива.
            Console.Write("Текущее содержимое: ");
            for (int i = 0; i < al.Count; i++)
                Console.Write(al[i] + " ");
            Console.WriteLine("\n");

            Console.WriteLine("Удалить 2 элемента");
            // Удалить элементы из динамического массива.
            al.Remove('F');
            al.Remove('A');

            Console.WriteLine("Количество элементов: " + al.Count);

            // Отобразить содержимое динамического массива, используя цикл foreach.
            Console.Write("Содержимое: ");
            foreach (char c in al)
                Console.Write(c + " ");
            Console.WriteLine("\n");

            Console.WriteLine("Добавить еще 20 элементов");
            // Добавить количество элементов, достаточное для
            // принудительного расширения массива.
            for (int i = 0; i < 20; i++)
                al.Add((char)('a' + i));
            Console.WriteLine("Текущая емкость: " + al.Capacity);
            Console.WriteLine("Количество элементов после добавления 20 новых: " + al.Count);
            Console.Write("Содержимое: ");
            foreach (char c in al)
                Console.Write(c + " ");
            Console.WriteLine("\n");

            // Изменить содержимое динамического массива,
            // используя индексирование массива.
            Console.WriteLine("Изменить три первых элемента");
            al[0] = 'X';
            al[1] = 'Y';
            al[2] = 'Z';
            Console.Write("Содержимое: ");
            foreach (char c in al)
                Console.Write(c + " ");
            Console.WriteLine();
        }
    }
}
