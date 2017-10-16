// Продемонстрировать применение директивы #else.
#define EXPERIMENTAL
using System;

namespace ca2
{
    class Test
    {
        static void Main()
        {
            #if EXPERIMENTAL
            Console.WriteLine("Компилируется для экспериментальной версии.");
#else
            Console.WriteLine("Компилируется для окончательной версии.");
#endif

            #if EXPERIMENTAL && TRIAL
            Console.Error.WriteLine("Проверка пробной экспериментальной версии.");
#else
            Console.Error.WriteLine("Это не пробная экспериментальная версия.");
#endif
            Console.WriteLine("Присутствует во всех версиях.");
        }
    }
}
