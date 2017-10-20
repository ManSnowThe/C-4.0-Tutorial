// Продемонстрировать применение встроенного атрибута Conditional.
#define TRIAL

using System;
using System.Diagnostics;

namespace ca2
{
    class Test
    {
        [Conditional("TRIAL")]
        void Trial()
        {
            Console.WriteLine("Пробная версия, не предназначенная для распространения.");
        }
        [Conditional("RELEASE")]
        void Release()
        {
            Console.WriteLine("Окончательная рабочая версия.");
        }
        static void Main()
        {
            Test t = new Test();

            t.Trial(); // вызывается только в том случае, если определен идентификатор TRIAL
            t.Release(); // вызывается только в том случае, если определен идентификатор RELEASE
        }
    }
}
