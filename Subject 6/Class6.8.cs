using System;

namespace ca2
{
    class Rect
    {
        public int Width;
        public int Height;

        public Rect(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        
        public int Area()
        {
            return this.Width * this.Height;
        }
    }
    class RectDemo
    {
        static void Main()
        {
            Rect r1 = new Rect(4, 5);
            Rect r2 = new Rect(7, 9);

            Console.WriteLine("Площадь прямоугольника r1: " + r1.Area());
            Console.WriteLine("Площадь прямоугольника r2: " + r2.Area());

        }
    }
}
