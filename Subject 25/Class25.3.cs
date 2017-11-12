// Преобразовать коллекцию типа ArrayList в обычный массив.
using System;
using System.Collections;
namespace ca2
{
    class ArrayListToArray
    {
        static void Main()
        {
            ArrayList al = new ArrayList();

            // Добавить элементы в динамический массив.
            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Add(4);

            Console.Write("Содержимое: ");
            foreach (int i in al)
                Console.Write(i + " ");
            Console.WriteLine();

            // Получить массив.
            int[] ia = (int[])al.ToArray(typeof(int));
            int sum = 0;

            // Просуммировать элементы массива.
            for (int i = 0; i < ia.Length; i++)
                sum += ia[i];
            Console.WriteLine("Сумма равна: " + sum);
        }
    }
}
