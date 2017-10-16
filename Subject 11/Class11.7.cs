// Пример сокрытия имени с наследственной связью.
// Применение ключевого слова base для преодоления
// препятствия, связанного с сокрытием имен.
using System;

namespace ca2
{
    class A
    {
        public int i = 0;
    }
    
    // Создать производный класс.
    class B :A
    {
        new int i;  // этот член скрывает член i из класса А
        public B(int a, int b)
        {
            base.i = a; // здесь обнаруживается скрытый член из класса A
            i = b; // член i из класса B
        }

        public void Show()
        {
            // Здесь выводится член i из класса А.
            Console.WriteLine("Член i в базовом классе: " + base.i);

            // Здесь выводится член i из класса B.
            Console.WriteLine("Член i в производном классе: " + i);
        }
    }
    class UncoverName
    {
        static void Main()
        {
            B ob = new ca2.B(1, 2);

            ob.Show();
        }
    }
}
