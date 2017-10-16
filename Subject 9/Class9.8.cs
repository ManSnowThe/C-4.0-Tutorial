// Применить явное преобразование.
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
        // Перегрузить бинарный оператор +.
        public static ThreeD operator +(ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();

            result.x = op1.x + op2.x;
            result.y = op1.y + op2.y;
            result.z = op1.z + op2.z;
            return result;        }
        // Выполнить на этот раз явное преобразование типов.
        public static explicit operator int(ThreeD op1)
        {
            return op1.x * op1.y * op1.z;
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

            int i;

            Console.Write("Координаты точки a: ");
            a.Show();
            Console.WriteLine();

            Console.Write("Координаты точки b: ");
            b.Show();
            Console.WriteLine();

            c = a + b; // сложить координаты точек а и b
            Console.Write("Результат сложения a + b: ");
            c.Show();
            Console.WriteLine();

            i = (int)a; // преобразовать в тип int явно,
                        // поскольку указано приведение типов
            Console.WriteLine("Результат присваивания i=a: " + i);
            Console.WriteLine();

            i = (int)a * 2 - (int)b; // явно требуется приведение типов
            Console.WriteLine("Результат вычисления выражения a * 2 - b: " + i);
        }
    }
}
