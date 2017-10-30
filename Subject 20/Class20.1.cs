// Продемонстрировать применение указателей и ключевого слова unsafe.
using System;

namespace ca2
{
    class UnsafeCode
    {
        // Пометить метод Main() как небезопасный.
         unsafe static void Main()
        {
            int count = 99;
            int* p; // создать указатель типа int

            p = &count; // поместить адрес переменной count в переменной р

            Console.WriteLine("Исходное значение переменной count: " + *p);
            *p = 10; // присвоить значение 10 переменной count, на которую указывает переменная p

            Console.WriteLine("Новое значение переменной count: " + *p);
        }
    }
}
