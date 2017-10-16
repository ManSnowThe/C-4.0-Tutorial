// Вызвать скрытый метод.
using System;

namespace ca2
{
    class A
    {
        public int i = 0;

        // Метод Show() в классе A
        public void Show()
        {
            Console.WriteLine("Член i в базовом классе: " + i);
        }
    }
    // Создать производный класс.
    class B : A
    {
        new int i; // этот член скрывает член i из класса А
        public B(int a, int b)
        {
            base.i = a; // здесь обнаруживается скрытый член из класса А
            i = b; // член i из класса В
        }
        // Здесь скрывается метод Show() из класса А. Обратите
        // внимание на применение ключевого слова new.
        new public void Show()
        {
            base.Show(); // здесь вызывается метод Show() из класса А

            // далее выводится член i из класса В
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
