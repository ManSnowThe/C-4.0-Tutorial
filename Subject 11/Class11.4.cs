// Добавить конструктор в класс Triangle.using System;

namespace ca2
{
    // Класс для двумерных объектов.
    class TwoDShape
    {
        double pri_width;
        double pri_height;

        // Свойства ширины и длины объекта.        public double Width
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
            Console.WriteLine("Ширина и длина равны: " + Width + " и " + Height);
        }
    }
    // Класс для треугольников, производный от класса TwoDShape.    class Triangle : TwoDShape
    {
        string Style;

        // Конструктор.
        public Triangle(string s, double w, double h)
        {
            Width = w; // инициализировать член базового класса
            Height = h; // инициализировать член базового класса
            Style = s; // инициализировать член производного класса
        }
        // Возвратить площадь треугольника.
        public double Area()
        {
            return Width*Height / 2;
        }
        // Показать тип треугольника.
        public void ShowStyle()
        {
            Console.WriteLine("Треугольник " + Style);
        }
    }
    class Shape3
    {
        static void Main()
        {
            Triangle t1 = new Triangle("равнобедренный", 4.0, 4.0);
            Triangle t2 = new Triangle("прямоугольный", 8.0, 12.0);

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
