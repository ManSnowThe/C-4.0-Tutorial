// Пространства имен предотвращают конфликты имен.using System;

// Объявить пространство имен Counter.
namespace Counter
{
    // Простой вычитающий счетчик.
    class CountDown
    {
        int val;

        public CountDown(int n)
        {
            val = n;
        }
        public void Reset(int n)
        {
            val = n;
        }
        public int Count()
        {
            if (val > 0) return val--;
            else return 0;
        }
    }
}
// Объявить пространство имен Counter2.
namespace Counter2
{
    /* Этот класс CountDown относится к пространству
     * имен Counter2 и поэтому не вступает в конфликт
     * с аналогичным классом из пространства имен Counter.
     */
     class CountDown
    {
        public void Count()
        {
            Console.WriteLine("Это метод Count() из пространства имен Counter2.");
        }
    }
}

class NSDemo2
{
    static void Main()
    {
        // Это класс CountDown из пространства имен Counter.
        Counter.CountDown cd1 = new Counter.CountDown(10);
        Counter2.CountDown cd2 = new Counter2.CountDown();

        int i;
        do
        {
            i = cd1.Count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();

        cd2.Count();
    }
}
