// Продемонстрировать применение метода Concat().
using System;

namespace ca2
{
    class ConcatDemo
    {
        static void Main()
        {
            string result = String.Concat("Это ", "тест ", "метода ", "сцепления ", "строк ", "из класса ", "String.");
            Console.WriteLine("Результат: " + result);
        }
    }
}
