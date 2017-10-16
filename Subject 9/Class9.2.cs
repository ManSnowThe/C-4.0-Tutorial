// Перегрузить бинарный оператор + трижды:
// один раз — для сложения объектов класса ThreeD,
// второй раз — для сложения объекта типа ThreeD и целого значения типа int,
// а третий раз — для сложения целого значения типа int и объекта типа ThreeD.
using System;

namespace ca2
{
    // Класс для хранения трехмерных координат.
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
        // Перегрузить бинарный оператор + для сложения объектов класса ThreeD.
        public static ThreeD operator +(ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();

            /* Сложить координаты двух точек и возвратить результат. */
            result.x = op1.x + op2.x;
            result.y = op1.y + op2.y;
            result.z = op1.z + op2.z;

            return result;
        }
        // Перегрузить бинарный оператор + для сложения
        // объекта типа ThreeD и целого значения типа int.
        public static ThreeD operator +(ThreeD op1, int op2)
        {
            ThreeD result = new ThreeD();

            result.x = op1.x + op2;
            result.y = op1.y + op2;
            result.z = op1.z + op2;

            return result;
        }
        
        // Перегрузить бинарный оператор + для сложения
        // целого значения типа int и объекта типа ThreeD.
        public static ThreeD operator +(int op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();
            result.x = op2.x + op1;
            result.y = op2.y + op1;
            result.z = op2.z + op1;
            return result;
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
            ThreeD a = new ThreeD(1, 2, 3);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c = new ThreeD();

            Console.Write("Координаты точки a: ");
            a.Show();
            Console.WriteLine();

            Console.Write("Координаты точки b: ");
            b.Show();
            Console.WriteLine();

            c = a + b; // сложить объекты класса ThreeD
            Console.Write("Результат сложения a + b: ");
            c.Show();
            Console.WriteLine();

            c = b + 10; // сложить объект типа ThreeD и целое значение типа int
            Console.Write("Результат сложения b + 10: ");
            c.Show();
            Console.WriteLine();

            c = 15 + b; // сложить целое значение типа int и объект типа ThreeD
            Console.Write("Результат сложения 15 + b: ");
            c.Show();
        }
    }
}
