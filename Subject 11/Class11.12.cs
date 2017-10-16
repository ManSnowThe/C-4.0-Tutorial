// Передать ссылку на объект производного класса
// переменной ссылки на объект базового класса.
using System;

namespace ca2
{
    class TwoDShape
    {
        double pri_width;
        double pri_height;

        // Конструктор по умолчанию.
        public TwoDShape()
        {
            Width = Height = 0.0;
        }

        // Конструктор для класса TwoDShape
        public TwoDShape(double w, double h)
        {
            Width = w;
            Height = h;
        }
        // Сконструировать объект равной ширины и высоты.
        public TwoDShape(double x)
        {
            Width = Height = x;
        }
        // Сконструировать копию объекта TwoDShape.
        public TwoDShape(TwoDShape ob)
        {
            Width = ob.Width;
            Height = ob.Height;
        }
        // Свойства ширины и высоты объекта.        public double Width
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
    // Класс для треугольников, производный от класса TwoDShape.
    class Triangle : TwoDShape
    {
        string Style;

        // Конструктор используемый по умолчанию
        public Triangle()
        {
            Style = "null";
        }
        // Конструктор для класса Triangle.
        public Triangle(string s, double w, double h) : base(w, h)
        {
            Style = s;
        }
    // Сконструировать равнобедренный треугольник.
    public Triangle(double x) : base(x)
        {
        Style = "равнобедренный";
        }
    // Сконструировать копию объекта типа Triangle.
    public Triangle(Triangle ob) : base(ob)
        {
        Style = ob.Style;
        }
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
    class Shapes7
    {
        static void Main()
        {
            Triangle t1 = new Triangle("прямоугольный", 8.0, 12.0);
            
            // Сделать копию объекта t1.
            Triangle t2 = new Triangle(t1);

            Console.WriteLine("Сведения об объекте t1: ");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Площадь равна " + t1.Area());

            Console.WriteLine();

            Console.WriteLine("Сведения об объекте t2: ");
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Площадь равна " + t2.Area());        }
    }
}