//Поменять местами два значения
using System;

namespace ca2
{
    class ValueSwap
    {
        // Этот метод меняет местами свои аргументы.
        public void Swap(ref int a, ref int b)
        {
            int t;
            t = a;
            a = b;
            b = t;
        }

        class SwapDemo
        {
            static void Main()
            {
                ValueSwap ob = new ValueSwap();

                int x = 10;
                int y = 20;

                Console.WriteLine("x и у до вызова: " + x + " " + y);

                ob.Swap(ref x, ref y);

                Console.WriteLine("x и y после вызова: " + x + " " + y);
            }
        }
    }
}
