// Передача аргументов обычных типов по значению.
using System;

namespace ca2
{
    class Test
    {
        /* Этот метод не оказывает никакого влияния на
        аргументы, используемые для его вызова. */
        public void NoChange(int i, int j)
        {
            i = i + j;
            j = -j;
        }
    }
    class CallByValue
    {
        static void Main()
        {
            Test ob = new Test();
            int a = 15, b = 20;

            Console.WriteLine("а и b до вызова: " +
            a + " " + b);

            ob.NoChange(a, b);

            Console.WriteLine("а и b после вызова: " +
            a + " " + b);
        }
    }
}