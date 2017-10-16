// Создать абстрактный класс.
using System;

namespace ca2
{
    abstract class TwoDShape
    {
        double pri_width;
        double pri_height;

        // Конструктор по умолчанию
        public TwoDShape()
        {
            Width = Height = 0.0;
            name = "null";
        }
        // Параметризированный конструктор.
        public TwoDShape(double w, double h, string n)
        {
            Width = w;
            Height = h;
            name = n;
        }
        // Сконструировать объект равной ширины и высоты.
        public TwoDShape(double x, string n)
        {
            Width = Height = x;
            name = n;
        }
        // Сконструировать копию объекта TwoDShape.
        public TwoDShape(TwoDShape ob)
        {
            Width = ob.Width;
            Height = ob.Height;
            name = ob.name;
        }

        // Свойства ширины и высоты объекта.
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

        public string name
        {
            get;
            set;
        }
        public void ShowDim()
        {
            Console.WriteLine("Ширина и высота равны " +
            Width + " и " + Height);
        }

        // Теперь метод Area() является абстрактным.
        public abstract double Area();
    }

    // Класс для треугольников, производный от класса TwoDShape.
    class Triangle : TwoDShape
    {
        string Style;

        // Конструктор, используемый по умолчанию
        public Triangle()
        {
            Style = "null";
        }

        // Конструктор для класса Triangle.
        public Triangle(string s, double w, double h) : base(w, h, "треугольник")
        {
            Style = s;
        }
        // Сконструировать равнобедренный треугольник.
        public Triangle(double x) : base(x, "треугольник")
        {
            Style = "равнобедренный";
        }

        // Сконструировать копию объекта типа Triangle.
        public Triangle(Triangle ob) : base(ob)
        {
            Style = ob.Style;
        }

        // Переопределить метод Area() для класса Triangle.
        public override double Area()
        {
            return Width * Height / 2;
        }

        // Показать тип треугольника.
        public void ShowStyle()
        {
            Console.WriteLine("Треугольник " + Style);
        }
    }
    // Класс для прямоугольников, производный от класса TwoDShape.
    class Rectangle : TwoDShape
    {
        // Конструктор для класса Rectangle.
        public Rectangle(double w, double h) : base(w, h, "прямоугольник")
        {

        }
        // Сконструировать квадрат.
        public Rectangle(double x) : base(x, "квадрат")
        {

        }
        // Сконструировать копию объекта типа Rectangle.
        public Rectangle(Rectangle ob) : base(ob)
        {

        }
        // Возвратить логическое значение true, если
        // прямоугольник окажется квадратом.
        public bool IsSquare()
        {
            if (Width == Height) return true;
            return false;
        }        // Переопределить метод Area() для класса Rectangle.
        public override double Area()
        {
            return Width * Height;
        }
    }
    class DynShapes
    {
        static void Main()
        {
            TwoDShape[] shapes = new TwoDShape[4];

            shapes[0] = new Triangle("прямоугольный", 8.0, 12.0);
            shapes[1] = new Rectangle(10);
            shapes[2] = new Rectangle(10, 4);
            shapes[3] = new Triangle(7.0);

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine("Объект — " + shapes[i].name);
                Console.WriteLine("Площадь равна " + shapes[i].Area());

                Console.WriteLine();
            }
        }
    }
}
