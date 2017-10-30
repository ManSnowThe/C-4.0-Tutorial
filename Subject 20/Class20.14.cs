// Продемонстрировать определения частичного класса.
// +
// Продемонстрировать применение частичного метода.
using System;

namespace ca2
{
    // Cодержимое первого файла.
    partial class XY
    {
        public XY(int a, int b)
        {
            X = a;
            Y = b;
        }
        // Объявить частичный метод.
        partial void Show();
    }
    // Далее следует содержимое второго файла.
    partial class XY
    {
        public int X { get; set; }

        // Реализовать частичный метод
        partial void Show()
        {
            Console.WriteLine("{0}, {1}", X, Y);
        }
    }
    // И наконец, содержимое третьего файла.
    partial class XY
    {
        public int Y { get; set; }
        // Вызвать частичный метод.
        public void ShowXY()
        {
            Show();
        }
    }
    // В приведенном ниже файле исходного текста программы демонстрируется при­ менение класса XY.
    class Test
    {
        static void Main()
        {
            XY xy = new XY(1, 2);
            xy.ShowXY();
        }
    }
}
