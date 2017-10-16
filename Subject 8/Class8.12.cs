// Использовать обычный параметр вместе с параметром
// переменной длины типа params.
using System;

namespace ca2
{
    class MyClass
    {
        public void ShowArgs(string msg, params int[] nums)
        {
            Console.Write(msg + " ");

            foreach (int i in nums)
                Console.Write(i + " ");

            Console.WriteLine();
        }
    }
    class ParamsDemo
    {
        static void Main()
        {
            MyClass ob = new MyClass();

            ob.ShowArgs("Это ряд целых чисел:", 1, 2, 3, 4, 5);
            ob.ShowArgs("А это еще два целых числа:", 17, 20);
        }
    }
}
