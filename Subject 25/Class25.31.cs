// Пример применения нескольких операторов yield.
using System;
using System.Collections;
namespace ca2
{
    class MyClass
    {
        // Этот итератор возвращает буквы А, В, С, D и Е.
        public IEnumerator GetEnumerator()
        {
            yield return 'A';
            yield return 'B';
            yield return 'C';
            yield return 'D';
            yield return 'E';
        }
    }
    class ItrDemo4
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
