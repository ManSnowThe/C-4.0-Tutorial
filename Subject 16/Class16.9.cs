// Использовать идентификаторное выражение.#define EXPERIMENTAL
#define TRIAL

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

#if EXPERIMENTAL && TRIAL
            Console.WriteLine("Проверка пробной экспериментальной версии.");
#endif
            Console.WriteLine("Присутствует во всех версиях.");
        }
    }
}
