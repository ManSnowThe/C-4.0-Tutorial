// Пример прерывания итератора.
using System;
using System.Collections;

namespace ca2
{
    class MyClass
    {
        char ch = 'A';

        // Этот итератор возвращает первые 10 букв английского алфавита.
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 26; i++)
            {
                if (i == 10) yield break; // прервать итератор преждевременно
                yield return (char)(ch + i);
            }
        }
    }
    class ItrDemo3
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
