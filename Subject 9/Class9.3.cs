// Перегрузить операторы < и >.
using System;

namespace ca2
{
    class ThreeD
    {
        int x, y, z; // трехмерные координаты
        public ThreeD()
        {
            x = y = z = 0;
        }
        public ThreeD(int i, int j, int k)
        {
            x = i;
            y = j;
            z = k;
        }
        // Перегрузить оператор <.
        public static bool operator <(ThreeD op1, ThreeD op2)
        {
            if (Math.Sqrt(op1.x * op1.x + op1.y * op1.y + op1.z * op1.z) <
                 Math.Sqrt(op2.x * op2.x + op2.y * op2.y + op2.z * op2.z))
                return true;
            else
                return false;
        }
        // Перегрузить оператор >.
        public static bool operator >(ThreeD op1, ThreeD op2)
        {
            if (Math.Sqrt(op1.x * op1.x + op1.y * op1.y + op1.z * op1.z) >
Math.Sqrt(op2.x * op2.x + op2.y * op2.y + op2.z * op2.z))
                return true;
            else
                return false;
        }
        // Вывести координаты X, Y, Z.
        public void Show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }
    }
    class ThreeDDemo
    {
        static void Main()
        {
            ThreeD a = new ThreeD(5, 6, 7);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c = new ThreeD(1, 2, 3);
            ThreeD d = new ThreeD(6, 7, 5);

            Console.Write("Координаты точки a: ");
            a.Show();
            Console.Write("Координаты точки b: ");
            b.Show();
            Console.Write("Координаты точки с: ");
            c.Show();
            Console.Write("Координаты точки d: ");
            d.Show();
            Console.WriteLine();

            if (a > c) Console.WriteLine("а > с истинно");
            if (a < c) Console.WriteLine("а < с истинно");
            if (a > b) Console.WriteLine("а > b истинно");
            if (a < b) Console.WriteLine("а < b истинно");

            if (a > d) Console.WriteLine("а > d истинно");
            else if (a < d) Console.WriteLine("a < d истинно");
            else Console.WriteLine("Точки a и d находятся на одном расстоянии " +
            "от начала отсчета");
        }
    }
}