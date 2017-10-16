//Продемонстрировать применение деструктора
using System;


namespace ca2
{
    class Destruct
    {
        public int x;

        public Destruct(int i)
        {
            x = i;
        }
        // Вызывается при утилизации объекта.
        ~Destruct()
        {
            Console.WriteLine("Уничтожить " + x);
        }

        //Создает объект и тут же уничтожает его.
        public void Generator(int i)
        {
            Destruct o = new Destruct(i);
        }
    }

    class DestructDemo
    {
        static void Main()
        {
            int count;

            Destruct ob = new Destruct(0);

            /* А теперь создать большое число объектов.
В какой-то момент произойдет "сборка мусора".
Примечание: для того чтобы активизировать
"сборку мусора", возможно, придется увеличить
число создаваемых объектов. */

            for (count = 1; count < 100000; count++)
                ob.Generator(count);

            Console.WriteLine("Готово!");
        }
    }
}
