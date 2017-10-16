// Использовать открытые свойства для установки и
// получения значений закрытых членов класса.
using System;

namespace ca2
{
    // Класс для двумерных объектов.
    class TwoDShape
    {
        double pri_width; // теперь это закрытая переменная
        double pri_height; // теперь это закрытая переменная

        // Свойства ширины и высоты двумерного объекта.
        public double Width
        {
            get { return pri_width; }
            set { pri_width = value < 0 ? -value : value; }
        }
        public double Height
        {
            get { return pri_height; }
            set { pri_height = value < 0 ? -value : value; }
        }
        public void ShowDim()
        {
            Console.WriteLine("Ширина и высота равны " +
            Width + " и " + Height);
        }
    }
    // Класс для треугольников, производный от
    // класса TwoDShape.
    class Triangle : TwoDShape
    {
        public string Style; // тип треугольника
                             // Возвратить площадь треугольника.
        public double Area()
        {
            return Width * Height / 2;
        }
        // Показать тип треугольника.
        public void ShowStyle()
        {
            Console.WriteLine("Треугольник " + Style);
        }
    }
    class Shapes2
    {
        static void Main()
        {
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle();

            t1.Width = 4.0;
            t1.Height = 4.0;
            t1.Style = "равнобедренный";

            t2.Width = 8.0;
            t2.Height = 12.0;
            t2.Style = "прямоугольный";

            Console.WriteLine("Сведения об объекте t1: ");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Площадь равна " + t1.Area());

            Console.WriteLine();

            Console.WriteLine("Сведения об объекте t2: ");
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Площадь равна " + t2.Area());
        }
    }
}
