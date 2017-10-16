// Поменять местами две ссылки.
using System;

namespace ca2
{
    class RefSwap
    {
        int a, b;
        public RefSwap(int i, int j)
        {
            a = i;
            b = j;
        }

        public void Show()
        {
            Console.WriteLine("a: {0}, b: {1}", a, b);
        }
        // Этот метод изменяет свои аргументы.
        public void Swap(ref RefSwap ob1, ref RefSwap ob2)
        {
            RefSwap t;

            t = ob1;
            ob1 = ob2;
            ob2 = t;
        }
    }
    class RefSwapDemo
    {
        static void Main()
        {
            RefSwap x = new ca2.RefSwap(1, 2);
            RefSwap y = new ca2.RefSwap(3, 4);

            Console.Write("x до вызова: ");
            x.Show();

            Console.Write("y до вызова: ");
            y.Show();

            Console.WriteLine();

            // Смена объектов, на которые ссылаются аргументы х и у.
            x.Swap(ref x, ref y);

            Console.Write("x после вызова: ");
            x.Show();

            Console.Write("y полсе вызова: ");
            y.Show();
        }
    }
}
