// Продемонстрировать применение класса SortedSet<T>.
using System;
using System.Collections.Generic;

namespace ca2
{
    class SortedSetDemo
    {
        static void Show(string msg, SortedSet<char> set)
        {
            Console.Write(msg);
            foreach (char ch in set)
                Console.Write(ch + " ");
            Console.WriteLine();
        }
        static void Main()
        {
            SortedSet<char> setA = new SortedSet<char>();
            SortedSet<char> setB = new SortedSet<char>();

            setA.Add('A');
            setA.Add('B');
            setA.Add('C');

            setB.Add('C');
            setB.Add('D');
            setB.Add('E');

            Show("Исходное содержимое множества SetA: ", setA);
            Show("Исходное содержимое множества SetB: ", setB);

            setA.SymmetricExceptWith(setB);
            Show("Содержимое множества setA после разноименности со множеством SetB: ", setA);

            setA.UnionWith(setB);
            Show("Содержимое множества setA после объединения со множеством SetB: ", setA);

            setA.ExceptWith(setB);
            Show("Содержимое множества setA после вычитания из множества setB: ", setA);

            Console.WriteLine();
        }
    }
}
