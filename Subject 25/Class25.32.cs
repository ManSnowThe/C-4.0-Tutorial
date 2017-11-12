// Использовать именованные итераторы.
using System;
using System.Collections;

namespace ca2
{
    class MyClass
    {
        char ch = 'A';

        // Этот итератор возвращает буквы английского алфавита,
        // начиная с буквы А и кончая указанным конечным пределом.
        public IEnumerable MyItr(int end)
        {
            for (int i = 0; i < end; i++)
                yield return (char)(ch + i);
        }
        // Этот итератор возвращает буквы в заданных пределах.
        public IEnumerable MyItr(int begin, int end)
        {
            for (int i = begin; i < end; i++)
                yield return (char)(ch + i);
        }
    }
    class ItrDemo5
    {
        static void Main()
        {
            MyClass mc = new MyClass();

            Console.WriteLine("Возвратить по очереди первые 7 букв:");
            foreach (char ch in mc.MyItr(7))
                Console.Write(ch + " ");

            Console.WriteLine("\n");

            Console.WriteLine("Возвратить по очереди буквы от F до L:");
            foreach (char ch in mc.MyItr(5, 12))
                Console.Write(ch + " ");

            Console.WriteLine();
        }
    }
}
