// Простой способ перегрузки логических операторов
// !, | и & для объектов класса ThreeD.
using System;

namespace ca2
{
    // Класс для хранения трехмерных координат.
    class ThreeD
    {
        int x, y, z; // трехмерные кординаты

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
        // Перегрузить логический оператор |.
        public static bool operator |(ThreeD op1, ThreeD op2)
        {
            if (((op1.x != 0) || (op1.y != 0) || (op1.z != 0)) | ((op2.x != 0) || (op2.y != 0) || (op2.z != 0)))
                return true;
            else
                return false;
        }
        // Перегрузить логический оператор &.
        public static bool operator &(ThreeD op1, ThreeD op2)
        {
            if (((op1.x != 0) && (op1.y != 0) && (op1.z != 0)) &
((op2.x != 0) && (op2.y != 0) && (op2.z != 0)))
                return true;
            else
                return false;
        }
        // Перегрузить логический оператор !.
        public static bool operator !(ThreeD op)
        {
            if ((op.x != 0) || (op.y != 0) || (op.z != 0))
                return false;
            else
                return true;
        }
        // Вывести координаты X, Y, Z.
        public void Show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }
    }
    class TrueFalseDemo
    {
        static void Main()
        {
            ThreeD a = new ThreeD(5, 6, 7);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c = new ThreeD(0, 0, 0);

            Console.Write("Координаты точки a: ");
            a.Show();
            Console.Write("Координаты точки b: ");
            b.Show();
            Console.Write("Координаты точки с: ");
            c.Show();
            Console.WriteLine();

            if (!a) Console.WriteLine("Точка а ложна.");
            if (!b) Console.WriteLine("Точка b ложна.");
            if (!c) Console.WriteLine("Точка с ложна.");
            Console.WriteLine();

            if (a & b) Console.WriteLine("a & b истинно.");
            else Console.WriteLine("a & b ложно.");
            if (a & c) Console.WriteLine("a & с истинно.");
            else Console.WriteLine("a & с ложно.");
            if (a | b) Console.WriteLine("a | b истинно.");
            else Console.WriteLine("a | b ложно.");
            if (a | c) Console.WriteLine("a | с истинно.");
            else Console.WriteLine("a | с ложно.");
        }
    }
}
