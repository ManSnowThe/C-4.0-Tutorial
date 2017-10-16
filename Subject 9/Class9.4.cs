// Перегрузить операторы true и false для класса ThreeD.
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
        // Перегрузить оператор true.
        public static bool operator true(ThreeD op)
        {
            if ((op.x != 0) || (op.y != 0) || (op.z != 0))
                return true; // хотя бы одна координата не равна нулю
            else
                return false;
        }
        // Перегрузить оператор false.
        public static bool operator false(ThreeD op)
        {
            if ((op.x == 0) && (op.y == 0) && (op.z == 0))
                return true; // все координаты равны нулю
            else
                return false;
        }

        // Перегрузить унарный оператор --.
        public static ThreeD operator --(ThreeD op)
        {
            ThreeD result = new ThreeD();

            // Возвратить результат декрементирования.
            result.x = op.x - 1;
            result.y = op.y - 1;
            result.z = op.z - 1;

            return result;
        }
        // Вывести координаты X, Y, Z.
        public void Show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }    }
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

            if (a) Console.WriteLine("Точка а истинна.");
            else Console.WriteLine("Точка а ложна.");

            if (b) Console.WriteLine("Точка b истинна.");
            else Console.WriteLine("Точка b ложна.");

            if (c) Console.WriteLine("Точка с истинна.");
            else Console.WriteLine("Точка с ложна.");

            Console.WriteLine();
            Console.WriteLine("Управление циклом с помощью объекта класса ThreeD.");
            do
            {
                b.Show();
                b--;
            }
            while (b);
        }
    }
}
