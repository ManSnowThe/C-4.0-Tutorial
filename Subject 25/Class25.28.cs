// Простой пример применения итератора.
using System;
using System.Collections;

namespace ca2
{
    class MyClass
    {
        char[] chrs = { 'A', 'B', 'C', 'D' };

        // Этот итератор возвращает символы из массива chrs.
        public IEnumerator GetEnumerator()
        {
            foreach (char ch in chrs)
                yield return ch;
        }
    }
    class ItrDemo
    {
        static void Main()
        {
            MyClass mc = new MyClass();

            foreach (char ch in mc)
                Console.Write(ch + " ");

            Console.WriteLine();
        }
    }
}
