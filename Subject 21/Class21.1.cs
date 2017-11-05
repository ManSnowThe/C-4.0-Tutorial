// Расчет гипотенузы по теореме Пифагора.
using System;

namespace ca2
{
    class Class21
    {
        static void Main()
        {
            double s1;
            double s2;
            double hypot;
            string str;

            Console.WriteLine("Введите длину первой стороны треугольника: ");
            str = Console.ReadLine();
            s1 = Double.Parse(str);

            Console.WriteLine("Введите длину второй стороны треугольника: ");
            str = Console.ReadLine();
            s2 = Double.Parse(str);

            hypot = Math.Sqrt(s1 * s1 + s2 * s2);
            Console.WriteLine("Длина гипотенузы равна " + hypot);
        }
    }
}
