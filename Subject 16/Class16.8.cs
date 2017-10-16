// Продемонстрировать применение директив
// #if, #endif и #define.
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
#endif
            Console.WriteLine("Присутствует во всех версиях.");
        }
    }
}
