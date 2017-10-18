// Файл, содержащий три класса и носящий имя MyClasses.cs.
using System;

namespace ca2
{
    class MyClass
    {
        int x;
        int y;

        public MyClass(int i)
        {
            Console.WriteLine("Конструирование класса MyClass(int). ");
            x = y = i;
            Show();
        }
        public MyClass(int i, int j)
        {
            Console.WriteLine("Конструирование класса MyClass(int, int). ");
            x = i;
            y = j;
            Show();
        }
        public int Sum()
        {
            return x + y;
        }
        public bool IsBetween(int i)
        {
            if ((x < i) && (i < y)) return true;
            else return false;
        }
        public void Set(int a, int b)
        {
            Console.Write("В методе Set(int, int). ");
            x = a;
            y = b;
            Show();
        }
        // Перегрузить метод Set.
        public void Set(double a, double b)
        {
            Console.Write("В методе Set(double, double). ");
            x = (int)a;
            y = (int)b;
            Show();
        }
        public void Show()
        {
            Console.WriteLine("Значение x: {0}, значение у: {1}", x, y);
        }
    }
    class AnotherClass
    {
        string msg;
        public AnotherClass(string str)
        {
            msg = str;
        }
        public void Show()
        {
            Console.WriteLine(msg);
        }
    }
    class Demo
    {
        static void Main()
        {
            Console.WriteLine("Это заполнитель.");
        }
    }
}
