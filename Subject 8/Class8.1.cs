// Отличия между видами доступа public и private к членам класса.
using System;

namespace ca2
{
    class MyClass
    {
        private int alpha; // закрытый доступ, указываемый явно
        int beta; // закрытый доступ по умолчанию
        public int gamma; // открытый доступ

        // Методы, которым доступны члены alpha и beta данного класса.
        // Член класса может иметь доступ к закрытому члену этого же класса.

        public void SetAlpha(int a)
        {
            alpha = a;
        }
        public int GetAlpha()
        {
            return alpha;
        }
        public void SetBeta(int a)
        {
            beta = a;
        }
        public int GetBeta()
        {
            return beta;
        }

    }
    class AccesDemo
    {
        static void Main()
        {
            MyClass ob = new MyClass();
            // Доступ к членам alpha и beta данного класса
            // разрешен только посредством его методов.
            ob.SetAlpha(-99);
            ob.SetBeta(19);
            Console.WriteLine("ob.alpha равно: " + ob.GetAlpha());
            Console.WriteLine("ob.beta равно: " + ob.GetBeta());

            // Следующие виды доступа к членам alpha и beta
            // данного класса не разрешаются.
            // ob.alpha = 10; // Ошибка! alpha - закрытый член!
            // ob.beta =9; // Ошибка! beta - закрытый член!
            // Член gamma данного класса доступен непосредственно,
            // поскольку он является открытым.
            ob.gamma = 99;

        }
    }
}
