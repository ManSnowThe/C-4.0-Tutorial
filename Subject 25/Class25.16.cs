// Продемонстрировать применение класса HashSet<T>.
using System;
using System.Collections.Generic;

namespace ca2
{
    class HashSetDemo
    {
        static void Show(string msg, HashSet<char> set)
        {
            Console.Write(msg);
            foreach (char ch in set)
                Console.Write(ch + " ");
            Console.WriteLine();
        }
        static void Main()
        {
            HashSet<char> setA = new HashSet<char>();
            HashSet<char> setB = new HashSet<char>();

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
