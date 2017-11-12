// Пример динамического построения значений,
// возвращаемых по очереди с помощью итератора.
using System;
using System.Collections;

namespace ca2
{
    class MyClass
    {
        char ch = 'A';

        // Этот итератор возвращает буквы английского
        // алфавита, набранные в верхнем регистре.
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 26; i++)
                yield return (char)(ch + i);
        }
    }
    class ItrDemo2
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
