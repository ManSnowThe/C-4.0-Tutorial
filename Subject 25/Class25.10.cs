// Продемонстрировать применение класса LinkedList<T>.
using System;
using System.Collections.Generic;

namespace ca2
{
    class GenLinkedListDemo
    {
        static void Main()
        {
            // Создать связный список.
            LinkedList<char> ll = new LinkedList<char>();

            Console.WriteLine("Исходное количество элементов в списке: " + ll.Count);

            Console.WriteLine();

            Console.WriteLine("Добавить в список 5 элементов");
            // Добавить элементы в связный список.
            ll.AddFirst('А');
            ll.AddFirst('В');
            ll.AddFirst('С');
            ll.AddFirst('D');
            ll.AddFirst('Е');
            Console.WriteLine("Количество элементов в списке: " + ll.Count);

            // Отобразить связный список, обойдя его вручную.
            LinkedListNode<char> node;

            Console.Write("Отобразить содержимое списка по ссылкам: ");
            for (node = ll.First; node != null; node = node.Next)
                Console.Write(node.Value + " ");

            Console.WriteLine("\n");

            // Отобразить связный список, обойдя его в цикле foreach.
            Console.Write("Отобразить содержимое списка в цикле foreach: ");
            foreach (char ch in ll)
                Console.Write(ch + " ");

            Console.WriteLine("\n");
            
            // Отобразить связный список, обойдя его вручную в обратном направлении.
            Console.Write("Следовать по ссылкам в обратном направлении: ");
            for (node = ll.Last; node != null; node = node.Previous)
                Console.Write(node.Value + " ");

            Console.WriteLine("\n");

            // Удалить из списка два элемента.
            Console.WriteLine("Удалить 2 элемента из списка");
           
            // Удалить элементы из связного списка.
            ll.Remove('С');
            ll.Remove('А');
            Console.WriteLine("Количество элементов в списке: " + ll.Count);

            // Отобразить содержимое видоизмененного списка в цикле foreach.
            Console.Write("Содержимое списка после удаления элементов: ");
            foreach (char ch in ll)
                Console.Write(ch + " ");

            Console.WriteLine("\n");

            // Добавить три элемента в конец списка.
            ll.AddLast('X');
            ll.AddLast('Y');
            ll.AddLast('Z');

            Console.Write("Содержимое списка после ввода элементов: ");
            foreach (char ch in ll)
                Console.Write(ch + " ");

            Console.WriteLine("\n");
        }
    }
}
