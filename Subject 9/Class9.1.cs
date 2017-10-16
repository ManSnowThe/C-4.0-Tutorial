// Пример перегрузки бинарных и унарных операторов.
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
            ThreeD result = new ca2.ThreeD();

            /* Сложить координаты двух точек и возвратить результат. */
            result.x = op1.x + op2.x; // Эти операторы выполняют
            result.y = op1.y + op2.y; // целочисленное сложение,
            result.z = op1.z + op2.z; // сохраняя свое исходное назначение.

            return result;
        }
        // Перегрузить бинарный оператор -.
        public static ThreeD operator -(ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ca2.ThreeD();
            
            /* Обратите внимание на порядок следования операндов:
op1 — левый операнд, а ор2 — правый операнд. */
            result.x = op1.x - op2.x; // Эти операторы
            result.y = op1.y - op2.y; // выполняют целочисленное
            result.z = op1.z - op2.z; // вычитание
            return result;
        }
        // Перегрузить унарный оператор -.
        public static ThreeD operator -(ThreeD op)
        {
            ThreeD result = new ThreeD();

            result.x = -op.x;
            result.y = -op.y;
            result.z = -op.z;

            return result;
        }
        
        // Перегрузить унарный оператор ++.
        public static ThreeD operator ++(ThreeD op)
        {
            ThreeD result = new ThreeD();

            // Возвратить результат инкрементирования.
            result.x = op.x + 1;
            result.y = op.y + 1;
            result.z = op.z + 1;

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
            ThreeD a = new ca2.ThreeD(1, 2, 3);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c;

            Console.Write("Координаты точки a: ");
            a.Show();
            Console.WriteLine();

            Console.Write("Координаты точки b: ");
            b.Show();
            Console.WriteLine();

            c = a + b; // сложить координаты точек а и b
            Console.Write("Результат сложения а + b: ");
            c.Show();
            Console.WriteLine();

            c = a + b + c; // сложить координаты точек а, b и с
            Console.Write("Результат сложения а + b + с: ");
            c.Show();
            Console.WriteLine();

            c = c - a; // вычесть координаты точки а
            Console.Write("Результат вычитания с - а: ");
            c.Show();
            Console.WriteLine();
            c = c - b; // вычесть координаты точки b
            Console.Write("Результат вычитания с - b: ");
            c.Show();
            Console.WriteLine();            c = -a; // присвоить точке с отрицательные координаты точки а
            Console.Write("Результат присваивания -а: ");
            c.Show();
            Console.WriteLine();

            c = a++; // присвоить точке с координаты точки а,
                     // а затем инкрементировать их
            Console.WriteLine("Если с = а++");
            Console.Write("то координаты точки с равны ");
            c.Show();

            Console.Write("а координаты точки а равны ");
            a.Show();

            // Установить исходные координаты (1,2,3) точки а
            a = new ThreeD(1, 2, 3);            Console.Write("\nУстановка исходных координат точки а: ");
            a.Show();
            c = ++a; // инкрементировать координаты точки а,
                     // а затем присвоить их точке с
            Console.WriteLine("\nЕсли с = ++а");
            Console.Write("то координаты точки с равны ");
            c.Show();

            Console.Write("а координаты точки а равны ");
            a.Show();
        }
    }
}
